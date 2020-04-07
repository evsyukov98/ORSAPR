using Kompas6API5;
using Kompas6Constants3D;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KompasGorka
{
    public partial class SlideApplication : Form
    {
        private FigureParams _figureParams;

        private KompasConnector _kompasConnector;

        public SlideApplication()
        {
            InitializeComponent();

            textBoxC.Text = Convert.ToString(8);
            textBoxD.Text = Convert.ToString(20);
            textBoxL.Text = Convert.ToString(80);
            textBoxG.Text = Convert.ToString(40);
            textBoxF.Text = Convert.ToString(40);
            textBoxA.Text = Convert.ToString(20);
            textBoxE.Text = Convert.ToString(20);

        }
        
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            _kompasConnector = new KompasConnector(); 
        }

        private void ButtonBuildSlide_Click(object sender, EventArgs e)
        {
            _kompasConnector.NewDocument();
            
            _figureParams = new FigureParams(int.Parse(textBoxC.Text),
                int.Parse(textBoxD.Text), int.Parse(textBoxL.Text),
                int.Parse(textBoxG.Text), int.Parse(textBoxF.Text),
                int.Parse(textBoxA.Text), int.Parse(textBoxE.Text));

            Builder builder = new Builder();

            builder.Build(_kompasConnector.iPart, _figureParams);
        }

        private void textBoxG_TextChanged(object sender, EventArgs e)
        {
            var pattern = @"\w+";
            if (Regex.IsMatch(textBoxG.Text, pattern))
            {
                
            }
            else
            {
                
            }
        }


        private void textBoxF_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
