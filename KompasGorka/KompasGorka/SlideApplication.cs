using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using KompasGorka.API;
using KompasGorka.Model;

namespace KompasGorka.GUI
{
    /// <summary>
    ///     Главная форма.
    /// </summary>
    public partial class SlideApplication : Form
    {
        /// <summary>
        ///     Параметры фигуры.
        /// </summary>
        private readonly FigureParams _figureParams = new FigureParams();

        /// <summary>
        ///     Словарь хранящий текстбоксы и строку с названием.
        /// </summary>
        private readonly Dictionary<TextBox, (string, string)> _paramsNames;

        /// <summary>
        ///     Класс для работы с API Компас 3D.
        /// </summary>
        private KompasConnector _kompasConnector;

        /// <summary>
        ///     Конструктор класса.
        /// </summary>
        public SlideApplication()
        {
            InitializeComponent();

            InitializeParams();

            _paramsNames = new Dictionary<TextBox, (string, string)>
            {
                {textBoxC, (nameof(_figureParams.BorderHeightC), "Высота бордюра")},
                {textBoxD, (nameof(_figureParams.EndLengthD), "Длина конца горки")},
                {textBoxL, (nameof(_figureParams.MainLengthL), "Длина горки")},
                {textBoxG, (nameof(_figureParams.PlatformHeightG), "Высота платформы")},
                {textBoxF, (nameof(_figureParams.PlatformLengthF), "Длина платформы")},
                {textBoxA, (nameof(_figureParams.SlideWidthA), "Ширина горки")},
                {textBoxE, (nameof(_figureParams.EndLengthD), "Длина конца горки")},
                {textBoxT, (nameof(_figureParams.PlatformThicknessT), "Толщина платформы")}
            };
        }

        /// <summary>
        ///     Кнопка включения компаса.
        /// </summary>
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            _kompasConnector = new KompasConnector();
        }

        /// <summary>
        ///     Кнопка построить фигуру.
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
        ///     Инициализация начальных параметров.
        /// </summary>
        private void InitializeParams()
        {
            textBoxC.Text = Convert.ToString(_figureParams.BorderHeightC);
            textBoxD.Text = Convert.ToString(_figureParams.EndLengthD);
            textBoxL.Text = Convert.ToString(_figureParams.MainLengthL);
            textBoxG.Text = Convert.ToString(_figureParams.PlatformHeightG);
            textBoxF.Text = Convert.ToString(_figureParams.PlatformLengthF);
            textBoxA.Text = Convert.ToString(_figureParams.SlideWidthA);
            textBoxE.Text = Convert.ToString(_figureParams.StartLengthE);
            textBoxT.Text = Convert.ToString(_figureParams.PlatformThicknessT);
        }

        /// <summary>
        ///     Валидирует параметры.
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

            return allErrorMessage.Length == 0 ? null : allErrorMessage;
        }

        /// <summary>
        ///     Валидирует один параметр.
        /// </summary>
        /// <param name="textBox">Выбор текстбокса который необходимо проверить.</param>
        /// <returns>Возвращает строку ошибки.</returns>
        private string ValidateParam(TextBox textBox)
        {
            string errorMessage = null;

            try
            {
                if (int.TryParse(textBox.Text, out var newFigureParam))
                {
                    switch (_paramsNames[textBox].Item1)
                    {
                        case nameof(_figureParams.BorderHeightC):
                            _figureParams.BorderHeightC = newFigureParam;
                            break;

                        case nameof(_figureParams.EndLengthD):
                            _figureParams.EndLengthD = newFigureParam;
                            break;

                        case nameof(_figureParams.MainLengthL):
                            _figureParams.MainLengthL = newFigureParam;
                            break;

                        case nameof(_figureParams.PlatformHeightG):
                            _figureParams.PlatformHeightG = newFigureParam;
                            break;

                        case nameof(_figureParams.PlatformLengthF):
                            _figureParams.PlatformLengthF = newFigureParam;
                            break;

                        case nameof(_figureParams.SlideWidthA):
                            _figureParams.SlideWidthA = newFigureParam;
                            break;

                        case nameof(_figureParams.StartLengthE):
                            _figureParams.StartLengthE = newFigureParam;
                            break;

                        case nameof(_figureParams.PlatformThicknessT):
                            _figureParams.PlatformThicknessT = newFigureParam;
                            break;

                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    throw new ArgumentException(_paramsNames[textBox].Item2 +
                                                " не является целочисленной.");
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