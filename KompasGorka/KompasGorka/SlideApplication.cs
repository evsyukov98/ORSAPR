using Kompas6API5;
using Kompas6Constants3D;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KompasGorka
{
    public partial class SlideApplication : Form
    {
        FigureParams FigureParams;

        // c помощью этого обьекта мы можем 
        // выбрать определенное окно приложения компас
        private KompasObject _kompas = null;

        // с помощью этого обьекта мы можем
        // создать 3Д документ для построения предметов
        private ksDocument3D _doc3D = null;

        public SlideApplication()
        {
            InitializeComponent();
            
        }

        // Кнопка запустить компас, береме контроль _kompas
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            // если окно компаса не включено
            // создать обьект компаса (т.е. обьект будет в процессе но не виден)
            if (_kompas == null)
            {
                Type t = Type.GetTypeFromProgID("KOMPAS.Application.5");
                _kompas = (KompasObject)Activator.CreateInstance(t);
            }

            // показать компас          
            _kompas.Visible = true;
            _kompas.ActivateControllerAPI(); 
        }

        // Кнопка построить
        private void buttonBuildSlide_Click(object sender, EventArgs e)
        {
            //если компас запущен
            if (_kompas == null)
            {
                return;
            }

                #region Подготовка компаса 
                // присвоить управление документами _doc3D
                _doc3D = (ksDocument3D)_kompas.Document3D();

                // создать документ
                _doc3D.Create(false/*invisible*/, true);

                //получить интерфейс детали
                ksPart iPart = (ksPart)_doc3D.GetPart((short)Part_Type.pTop_Part);
                #endregion

                // Построить коробку
                CreateCase(iPart);

            CreateCaseFace(iPart);
               
        }

        // Построить коробку
        private void CreateCase(ksPart iPart)
        {
            // Создаем обьект эскиза 
            ksEntity iSketch = (ksEntity)iPart.NewEntity((short)Obj3dType.o3d_sketch);
            
            // Получаем интерфейс свойств эскиза
            ksSketchDefinition iDefinitionSketch = iSketch.GetDefinition();

            // Устанавливаем плоскость эскиза плоскости ХОY
            iDefinitionSketch.SetPlane(iPart.GetDefaultEntity((short)Obj3dType.o3d_planeXOZ));

            // локация пока хз как 
            //iDefinitionSketch.SetLocation()

            // Теперь когда св-ва эскиза установлены можно его создать 
            iSketch.Create();

            // Берем у эскиза св-ва для черчений линий
            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            // Построить линию (x1,y1, x2,y2, style)
            iDocument2D.ksLineSeg(1, 2, 3, 3, 1);
            iDocument2D.ksLineSeg(1, 3, 3, 4, 1);

            iDocument2D.ksLineSeg(1, 2, 1, 3, 1);
            iDocument2D.ksLineSeg(3, 3, 3, 4, 1);

            // Закончить редактировать эскиз
            iDefinitionSketch.EndEdit();

            ExctrusionSketch(iPart, iSketch, 3, true);
        }

        // Построить коробку на поверхности другой
        private void CreateCaseFace(ksPart iPart)
        {
            // Создаем обьект эскиза 
            ksEntity iSketch = (ksEntity)iPart.NewEntity((short)Obj3dType.o3d_sketch);

            // Получаем интерфейс свойств эскиза
            ksSketchDefinition iDefinitionSketch = iSketch.GetDefinition();

            ksEntityCollection iCollection =
                (ksEntityCollection)iPart.EntityCollection((short)Obj3dType.o3d_face);

            #region очевидно что гдето здесь не может выбрать обьект 

            iCollection.SelectByPoint(1, 1.8f, 1.8f); 

            // Устанавливаем плоскость эскиза на поверхности другой
            iDefinitionSketch.SetPlane((ksEntity)iCollection.First());

            #endregion

            // Теперь когда св-ва эскиза установлены можно его создать 
            iSketch.Create();

            // Берем у эскиза св-ва для черчений линий
            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            // Построить линию (x1,y1, x2,y2, style)
            iDocument2D.ksLineSeg(1, 2, 3, 3, 1);

            // Закончить редактировать эскиз
            iDefinitionSketch.EndEdit();
        }

        /// <summary>
        /// Выдавливание по эскизу
        /// </summary>
        /// <param name="iPart">Интерфейс детали</param>
        /// <param name="iSketch">Эскиз</param>
        /// <param name="depth">Глубина выдавливания</param>
        /// <param name="type">Направление выдавливания</param>
        private void ExctrusionSketch(ksPart iPart, ksEntity iSketch, double depth, bool type)
        {
            //Операция выдавливание
            ksEntity entityExtr = (ksEntity)iPart.NewEntity((short)Obj3dType.o3d_bossExtrusion);

            //Интерфейс операции выдавливания
            ksBossExtrusionDefinition extrusionDef = (ksBossExtrusionDefinition)entityExtr.GetDefinition();

            //Интерфейс структуры параметров выдавливания
            ksExtrusionParam extrProp = (ksExtrusionParam)extrusionDef.ExtrusionParam();

            //Эскиз операции выдавливания
            extrusionDef.SetSketch(iSketch);

            //Направление выдавливания
            if (type == false)
            {
                extrProp.direction = (short)Direction_Type.dtReverse;
            }
            else
            {
                extrProp.direction = (short)Direction_Type.dtNormal;
            }

            //Тип выдавливания
            extrProp.typeNormal = (short)End_Type.etBlind;

            //Глубина выдавливания
            if (type == false)
            {
                extrProp.depthReverse = depth;
            }
            else
            {
                extrProp.depthNormal = depth;
            }

            //Создание операции
            entityExtr.Create();
        }

    }
}
