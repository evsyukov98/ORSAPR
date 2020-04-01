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
        private void ButtonBuildSlide_Click(object sender, EventArgs e)
        {
            figureParams = new FigureParams(int.Parse(textBoxC.Text),
                int.Parse(textBoxD.Text), int.Parse(textBoxL.Text),
                int.Parse(textBoxG.Text), int.Parse(textBoxF.Text),
                int.Parse(textBoxA.Text), int.Parse(textBoxE.Text));

            Builder builder = new Builder();
            builder.Build(kompasConnector.iPart, figureParams);
        }
     
    }
}
