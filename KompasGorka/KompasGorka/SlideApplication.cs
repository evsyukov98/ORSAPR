using Kompas6API5;
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
        // c помощью этого обьекта мы можем 
        // выбрать определенное окно приложения компас
        private KompasObject _kompas = null;

        // с помощью этого обьекта мы можем
        // создать 3Д документ для построения предметов
        private ksDocument3D _doc3D = null;

        // с помощью этого обьекта мы можем
        // создать эскиз и редактировать его
        private ksSketchDefinition _sketch;

        public SlideApplication()
        {
            InitializeComponent();
            
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            // если окно компаса не включено
            // создать обьект компаса (т.е. обьект будет в процессе но не виден)
            if (_kompas == null)
            {
                Type t = Type.GetTypeFromProgID("KOMPAS.Application.5");
                _kompas = (KompasObject)Activator.CreateInstance(t);

            }

            // если обьект создан
            // показать компас
            if (_kompas != null)
            {
                _kompas.Visible = true;
                _kompas.ActivateControllerAPI();
            }
        }

        private void buttonBuildSlide_Click(object sender, EventArgs e)
        {
            //если компас запущен
            if (_kompas != null) 
            {
                // присвоить управление документами _doc3D
                _doc3D = (ksDocument3D)_kompas.Document3D();

                // создать документ
                _doc3D.Create(false/*invisible*/, true);
              
            }

            
        }

        private void SlideApplication_Load(object sender, EventArgs e)
        {

        }

       
    }
}
