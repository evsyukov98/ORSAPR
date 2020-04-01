using Kompas6API5;
using Kompas6Constants3D;
using System;
using System.Windows.Forms;

namespace KompasGorka
{
    public partial class SlideApplication : Form
    {
        private FigureParams figureParams;

        private KompasConnector kompasConnector;


        public SlideApplication()
        {
            InitializeComponent();
            
        }
        
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            kompasConnector = new KompasConnector(figureParams); // подключаем компас
        }

        // Кнопка построить
        private void buttonBuildSlide_Click(object sender, EventArgs e)
        {
            Builder builder = new Builder();
            builder.Build(kompasConnector.iPart);
        }
     
    }
}
