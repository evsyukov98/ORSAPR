using System;
using System.Windows.Forms;
using KompasGorka.Model;

namespace KompasGorka.View
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

            InitializeParams();
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
                MessageBox.Show(@"Перед началом работы запустите компас нажав на кнопку - " +
                                @"Запустить компас");
                return;
            }

            try
            {
                if (int.TryParse(textBoxC.Text, out var figureParamC) 
                    && int.TryParse(textBoxD.Text, out var figureParamD)
                    && int.TryParse(textBoxL.Text, out var figureParamL) 
                    && int.TryParse(textBoxG.Text, out var figureParamG) 
                    && int.TryParse(textBoxF.Text, out var figureParamF) 
                    && int.TryParse(textBoxA.Text, out var figureParamA) 
                    && int.TryParse(textBoxE.Text, out var figureParamE))
                {
                    _figureParams = new FigureParams(figureParamC,
                        figureParamD, figureParamL,
                        figureParamG, figureParamF,
                        figureParamA, figureParamE);
                }
                else
                {
                    throw new ArgumentException("Неправильный ввод значений - " +
                                                "значения должны быть целочисленными");
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

        /// <summary>
        /// Инициализация начальный параметров
        /// </summary>
        private void InitializeParams()
        {
            textBoxC.Text = Convert.ToString(8);
            textBoxD.Text = Convert.ToString(20);
            textBoxL.Text = Convert.ToString(80);
            textBoxG.Text = Convert.ToString(40);
            textBoxF.Text = Convert.ToString(40);
            textBoxA.Text = Convert.ToString(20);
            textBoxE.Text = Convert.ToString(20);
        }
    }
}
