using Kompas6API5;
using Kompas6Constants3D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompasGorka
{
    class Builder
    {

        public void Build(ksPart iPart, FigureParams figureParams)
        {
            // Построить коробку
            CreateCase(iPart);
           
        }

        private void CreateCase(ksPart iPart)
        {
            // Создаем обьект эскиза 
            ksEntity iSketch = (ksEntity)iPart.NewEntity((short)Obj3dType.o3d_sketch);

            // Получаем интерфейс свойств эскиза
            ksSketchDefinition iDefinitionSketch = iSketch.GetDefinition();

            // Устанавливаем плоскость эскиза плоскости ХОY
            iDefinitionSketch.SetPlane(iPart.GetDefaultEntity((short)Obj3dType.o3d_planeXOZ));

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


        /*
        // Построить коробку на поверхности другой (пока не работает)
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
        }*/
    }
}
