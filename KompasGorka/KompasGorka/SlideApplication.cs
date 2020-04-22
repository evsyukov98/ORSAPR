using System;
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
                MessageBox.Show(@"Перед началом работы запустите компас нажав на кнопку - " +
                                @"Запустить компас.");
                return;
            }

            if (ValidateParams() != null)
            {
                MessageBox.Show(ValidateParams());
                return;
            }

            _kompasConnector.NewDocument();

            var builder = new Builder();

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
        }

        /// <summary>
        /// Валидирует параметры.
        /// </summary>
        /// <returns>Возвращает строку ошибок или null если ошибок нет.</returns>
        private string ValidateParams()
        {
            string errorMessage = null;

            try
            {
                if (int.TryParse(textBoxC.Text, out var figureParamC))
                {
                    _figureParams.BorderHeightC = figureParamC;
                }
                else
                {
                    throw new ArgumentException("Неправильный ввод значений - " +
                                                "Высота бордюра " +
                                                "должна быть целочисленными.");
                }
            }
            catch (ArgumentException exception)
            {
                errorMessage += exception.Message + "\n";
            }

            try
            {
                if (int.TryParse(textBoxD.Text, out var figureParamD))
                {
                    _figureParams.EndLengthD = figureParamD;
                }
                else
                {
                    throw new ArgumentException("Неправильный ввод значений - " +
                                                "Длина конца горки " +
                                                "должна быть целочисленными.");
                }
            }
            catch (ArgumentException exception)
            {
                errorMessage += exception.Message + "\n";
            }

            try
            {
                if (int.TryParse(textBoxL.Text, out var figureParamL))
                {
                    _figureParams.MainLengthL = figureParamL;
                }
                else
                {
                    throw new ArgumentException("Неправильный ввод значений - " +
                                                "Длина горки должна " +
                                                "быть целочисленными.");
                }
            }
            catch (ArgumentException exception)
            {
                errorMessage += exception.Message + "\n";
            }

            try
            {
                if (int.TryParse(textBoxG.Text, out var figureParamG))
                {
                    _figureParams.PlatformHeightG = figureParamG;
                }
                else
                {
                    throw new ArgumentException("Неправильный ввод значений - " +
                                                "Высота платформы должна " +
                                                "быть целочисленными.");
                }
            }
            catch (ArgumentException exception)
            {
                errorMessage += exception.Message + "\n";
            }

            try
            {
                if (int.TryParse(textBoxF.Text, out var figureParamF))
                {
                    _figureParams.PlatformLengthF = figureParamF;
                }
                else
                {
                    throw new ArgumentException("Неправильный ввод значений - " +
                                                "Длина платформы должна " +
                                                "быть целочисленными.");
                }
            }
            catch (ArgumentException exception)
            {
                errorMessage += exception.Message + "\n";
            }

            try
            {
                if (int.TryParse(textBoxA.Text, out var figureParamA))
                {
                    _figureParams.SlideWidthA = figureParamA;
                }
                else
                {
                    throw new ArgumentException("Неправильный ввод значений - " +
                                                "Ширина горки должна " +
                                                "быть целочисленными.");
                }
            }
            catch (ArgumentException exception)
            {
                errorMessage += exception.Message + "\n";
            }

            try
            {
                if (int.TryParse(textBoxE.Text, out var figureParamE))
                {
                    _figureParams.StartLengthE = figureParamE;
                }
                else
                {
                    throw new ArgumentException("Неправильный ввод значений - " +
                                                "Длина начала горки должна " +
                                                "быть целочисленными.");
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
