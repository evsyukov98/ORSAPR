using System;

namespace KompasGorka.Model
{
    /// <summary>
    /// Класс параметров фигуры
    /// </summary>
    public class FigureParams
    {
        /// <summary>
        /// Высота бордюра.
        /// </summary>
        private int _borderHeightC;

        /// <summary>
        /// Длина конца горки.
        /// </summary>
        private int _endLengthD;

        /// <summary>
        /// Длина горки.
        /// </summary>
        private int _mainLengthL;

        /// <summary>
        /// Высота платформы.
        /// </summary>
        private int _platformHeightG;

        /// <summary>
        /// Длина платформы.
        /// </summary>
        private int _platformLengthF;

        /// <summary>
        /// Ширина платформы.
        /// </summary>
        private int _slideWidthA;

        /// <summary>
        /// Длина начала горки.
        /// </summary>
        private int _startLengthE;

        /// <summary>
        /// Толщина платформы.
        /// </summary>
        private int _platformThicknessT;

        /// <summary>
        /// Создает экземпляр класса FigureParam.
        /// </summary>
        public FigureParams()
        {
            BorderHeightC = 8;
            EndLengthD = 20;
            MainLengthL = 80;
            PlatformHeightG = 40;
            PlatformLengthF = 40;
            SlideWidthA = 20;
            StartLengthE = 20;
            PlatformThicknessT = 3;
        }

        /// <summary>
        /// Высота бордюра.
        /// </summary>
        public int BorderHeightC
        {
            get => _borderHeightC;

            set
            {
                SetParam(8, 32, value);
                _borderHeightC = value;
            }
}

        /// <summary>
        /// Длина конца горки.
        /// </summary>
        public int EndLengthD
        {
            get => _endLengthD;

            set
            {
                SetParam(20, 60, value);
                _endLengthD = value;
            }
        }

        /// <summary>
        /// Длина горки.
        /// </summary>
        public int MainLengthL
        {
            get => _mainLengthL;

            set 
            { 
                SetParam(80, 240, value);
                _mainLengthL = value;
            }
}

        /// <summary>
        /// Высота платформы.
        /// </summary>
        public int PlatformHeightG
        {
            get => _platformHeightG;

            set 
            {
                SetParam(40, 160, value);
                _platformHeightG = value;
            }
    }

        /// <summary>
        /// Длина платформы.
        /// </summary>
        public int PlatformLengthF
        {
            get => _platformLengthF;

            set
            {
                SetParam(40, 120, value);
                _platformLengthF = value;
            }
        }

        /// <summary>
        /// Ширина горки.
        /// </summary>
        public int SlideWidthA
        {
            get => _slideWidthA;

            set
            {
                SetParam(20, 80, value);
                _slideWidthA = value;
            }
        }

        /// <summary>
        /// Длина начала горки.
        /// </summary>
        public int StartLengthE
        {
            get => _startLengthE;

            set
            {
                SetParam(20, 60, value);
                _startLengthE = value;
            }
        }

        ///<summary>
        /// Толщина платформы.
        /// </summary>
        public int PlatformThicknessT
        {
            get => _platformThicknessT;

            set 
            { 
                SetParam(3, 10, value);
                _platformThicknessT = value;
            }
        }

        private void SetParam(int min, int max, int value)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException("Неправильный ввод, значение ( " + value +
                                            " ) должно находиться в диапазоне от " + 
                                            min + " до " + max);
            }
        }
    }
}
