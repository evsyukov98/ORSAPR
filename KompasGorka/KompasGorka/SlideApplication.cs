using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using KompasGorka.API;
using KompasGorka.Model;

namespace KompasGorka.GUI
{
    public partial class SlideApplication : Form
    {
        /// <summary>
        /// Параметры фигуры.
        /// </summary>
        private readonly FigureParams _figureParams = new FigureParams();

        /// <summary>
        /// Класс для подключения Компаса 3D.
        /// </summary>
        private KompasConnector _kompasConnector;

        public SlideApplication()
        {
            InitializeComponent();

            InitializeParams();
        }

        /// <summary>
        /// Кнопка включения компаса.
        /// </summary>
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            _kompasConnector = new KompasConnector();
        }

        /// <summary>
        /// Кнопка построить фигуру.
        /// </summary>
        private void ButtonBuildSlide_Click(object sender, EventArgs e)
        {
            if (_kompasConnector == null)
            {
                MessageBox.Show(@"Перед началом работы запустите компас "
                                + @"нажав на кнопку - Запустить компас.");
                return;
            }

            if (ValidateParams() != null)
            {
                MessageBox.Show(ValidateParams());
                return;
            }

            try
            {
                _kompasConnector.NewDocument();
            }
            catch (COMException)
            {
                MessageBox.Show(@"Перед началом работы запустите компас " 
                                + @"нажав на кнопку - Запустить компас.");
                return;
            }

            var builder = new FigureBuilder();

            builder.Build(_kompasConnector.Part, _figureParams);
        }

        /// <summary>
        /// Инициализация начальный параметров.
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
            textBoxT.Text = Convert.ToString(3);
        }


        /// <summary>
        /// Валидирует все параметры.
        /// </summary>
        /// <returns>Возвращает строку ошибок или null если ошибок нет.</returns>
        private string ValidateParams()
        {
            var allErrorMessage = ValidateParam(textBoxC);

            allErrorMessage += ValidateParam(textBoxD);

            allErrorMessage += ValidateParam(textBoxL);

            allErrorMessage += ValidateParam(textBoxG);

            allErrorMessage += ValidateParam(textBoxF);

            allErrorMessage += ValidateParam(textBoxA);

            allErrorMessage += ValidateParam(textBoxE);

            allErrorMessage += ValidateParam(textBoxT);

            if (allErrorMessage.Length == 0)
                return null;

            return allErrorMessage;
        }

        /// <summary>
        /// Валидирует 1 параметр 
        /// </summary>
        /// <param name="textBox">Выбор текст бокса который необходимо проверить</param>
        /// <returns>Возвращает строку ошибки</returns>
        private string ValidateParam(TextBox textBox)
        {
            string errorMessage = null;

            try
            {
                if (int.TryParse(textBox.Text, out var newFigureParam))
                {
                    if (textBox == textBoxC)
                    {
                        _figureParams.BorderHeightC = newFigureParam;
                    }
                    else if (textBox == textBoxD)
                    {
                        _figureParams.EndLengthD = newFigureParam;
                    }
                    else if (textBox == textBoxL)
                    {
                        _figureParams.MainLengthL = newFigureParam;
                    }
                    else if (textBox == textBoxG)
                    {
                        _figureParams.PlatformHeightG = newFigureParam;
                    }
                    else if (textBox == textBoxF)
                    {
                        _figureParams.PlatformLengthF = newFigureParam;
                    }
                    else if (textBox == textBoxA)
                    {
                        _figureParams.SlideWidthA = newFigureParam;
                    }
                    else if (textBox == textBoxE)
                    {
                        _figureParams.StartLengthE = newFigureParam;
                    }
                    else 
                    {
                        _figureParams.PlatformThicknessT = newFigureParam;
                    }
                }
                else
                {
                    throw new ArgumentException("Неправильный ввод значений, символ ( " +
                                                textBox.Text +
                                                " ) не является целочисленным.");
                }
            }
            catch (ArgumentException exception)
            {
                errorMessage += exception.Message + "\n";
            }

            return errorMessage;
        }
    }
}
