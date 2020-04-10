using System;
using System.Windows.Forms;

namespace KompasGorka
{
    public partial class SlideApplication : Form
    {
        /// <summary>
        /// Параметры фигуры
        /// </summary>
        private FigureParams _figureParams;

        /// <summary>
        /// Класс для подключения Компаса 3D
        /// </summary>
        private KompasConnector _kompasConnector;

        public SlideApplication()
        {
            InitializeComponent();

            TextBoxC.Text = Convert.ToString(8);
            TextBoxD.Text = Convert.ToString(20);
            TextBoxL.Text = Convert.ToString(80);
            TextBoxG.Text = Convert.ToString(40);
            TextBoxF.Text = Convert.ToString(40);
            TextBoxA.Text = Convert.ToString(20);
            TextBoxE.Text = Convert.ToString(20);

        }
        
        /// <summary>
        /// Кнопка включения компаса
        /// </summary>
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            _kompasConnector = new KompasConnector(); 
        }

        /// <summary>
        /// Кнопка построить фигуру
        /// </summary>
        private void ButtonBuildSlide_Click(object sender, EventArgs e)
        {
            if (_kompasConnector == null)
            {
                MessageBox.Show(@"Перед началом работы запустите компас нажав на кнопку - Запустить компас");
                return;
            }

            try
            {
                if (
                    int.TryParse(TextBoxC.Text, out var figureParamC) 
                    && int.TryParse(TextBoxD.Text, out var figureParamD)
                    && int.TryParse(TextBoxL.Text, out var figureParamL) 
                    && int.TryParse(TextBoxG.Text, out var figureParamG) 
                    && int.TryParse(TextBoxF.Text, out var figureParamF) 
                    && int.TryParse(TextBoxA.Text, out var figureParamA) 
                    && int.TryParse(TextBoxE.Text, out var figureParamE)
                )
                {
                    _figureParams = new FigureParams(figureParamC,
                        figureParamD, figureParamL,
                        figureParamG, figureParamF,
                        figureParamA, figureParamE);
                }
                else
                {
                    throw new ArgumentException("Неправильный ввод значений - значения должны быть целочисленными");
                }
            }
            catch(ArgumentException exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

            _kompasConnector.NewDocument();
            var builder = new Builder();

            builder.Build(_kompasConnector.Part, _figureParams);
        }
    }
}
