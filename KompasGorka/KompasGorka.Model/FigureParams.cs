using System;

namespace KompasGorka.Model
{
    /// <summary>
    /// Класс параметров фигуры
    /// </summary>
    public class FigureParams
    {
        /// <summary>
        /// Высота бордюра
        /// </summary>
        private int _borderHeightC;

        /// <summary>
        /// Длина конца горки
        /// </summary>
        private int _endLengthD;

        /// <summary>
        /// Длина горки
        /// </summary>
        private int _mainLengthL;

        /// <summary>
        /// Высота платформы
        /// </summary>
        private int _platformHeightG;

        /// <summary>
        /// Длина платформы
        /// </summary>
        private int _platformLengthF;

        /// <summary>
        /// Ширина платформы
        /// </summary>
        private int _slideWidthA;

        /// <summary>
        /// Длина начала горки
        /// </summary>
        private int _startLengthE;

        /// <summary>
        /// Создает экземпляр класса FigureParam
        /// </summary>
        /// <param name="borderHeightC">Высота бордюра</param>
        /// <param name="endLengthD">Длина конца горки</param>
        /// <param name="mainLengthL">Длина горки</param>
        /// <param name="platformHeightG">Высота платформы</param>
        /// <param name="platformLengthF">Длина платформы</param>
        /// <param name="slideWidthA">Ширина платформы</param>
        /// <param name="startLengthE">Длина начала горки</param>
        public FigureParams(int borderHeightC,
            int endLengthD, 
            int mainLengthL, 
            int platformHeightG, 
            int platformLengthF, 
            int slideWidthA, 
            int startLengthE)
        {
            BorderHeightC = borderHeightC;
            EndLengthD = endLengthD;
            MainLengthL = mainLengthL;
            PlatformHeightG = platformHeightG;
            PlatformLengthF = platformLengthF;
            SlideWidthA = slideWidthA;
            StartLengthE = startLengthE;              
        }

        /// <summary>
        /// Высота бордюра
        /// </summary>
        public int BorderHeightC {
            get => _borderHeightC;
            set 
            {
                if (value < 8 || value > 32)
                {
                    throw new ArgumentException("Значение параметра -Высоты бордюра (C) " +
                                                "должно находиться в диапозоне от 8 до 32");
                }
                    
                _borderHeightC = value;
            } 
        }

        /// <summary>
        /// Длина конца горки
        /// </summary>
        public int EndLengthD
        {
            get => _endLengthD;

            set
            {
                if(value < 20 || value > 60)
                {
                    throw new ArgumentException("Значение параметра -Длина конца горки (D) " +
                                                "должно находиться в диапозоне от 20 до 60");
                }
                _endLengthD = value;
            }
        }

        /// <summary>
        /// Длина горки
        /// </summary>
        public int MainLengthL
        {
            get => _mainLengthL;

            set
            {
                if (value < 80 || value > 240)
                {
                    throw new ArgumentException("Значение параметра -Длина горки (L) " +
                                                "должно находиться в диапозоне от 80 до 240");
                }
                _mainLengthL = value;
            }
        }

        /// <summary>
        /// Высота платформы
        /// </summary>
        public int PlatformHeightG
        {
            get => _platformHeightG;

            set
            {
                if (value < 40 || value > 160)
                {
                    throw new ArgumentException("Значение параметра -Высота платформы (G) " +
                                                "должно находиться в диапозоне от 40 до 160");
                }
                _platformHeightG = value;
            }
        }

        /// <summary>
        /// Длина платформы
        /// </summary>
        public int PlatformLengthF
        {
            get => _platformLengthF;

            set
            {
                if (value < 40 || value > 120)
                {
                    throw new ArgumentException("Значение параметра -Длина платформы (F) " +
                                                "должно находиться в диапозоне от 40 до 120");
                }
                _platformLengthF = value;
            }
        }

        /// <summary>
        /// Ширина горки
        /// </summary>
        public int SlideWidthA
        {
            get => _slideWidthA;

            set
            {
                if (value < 20 || value > 80)
                {
                    throw new ArgumentException("Значение параметра -Ширина горки (A) " +
                                                "должно находиться в диапозоне от 20 до 80");
                }
                _slideWidthA = value;
            }
        }

        /// <summary>
        /// Длина начала горки
        /// </summary>
        public int StartLengthE
        {
            get => _startLengthE;

            set
            {
                if (value < 20 || value > 60)
                {
                    throw new ArgumentException("Значение параметра -Длина начала горки (E) " +
                                                "должно находиться в диапозоне от 20 до 60");
                }
                _startLengthE = value;
            }
        }
    }
}
