﻿using System;

namespace KompasGorka.Model
{
    /// <summary>
    ///     Класс параметров фигуры.
    /// </summary>
    public class FigureParams
    {
        /// <summary>
        ///     Высота бордюра.
        /// </summary>
        private int _borderHeightC;

        /// <summary>
        ///     Длина конца горки.
        /// </summary>
        private int _endLengthD;

        /// <summary>
        ///     Длина горки.
        /// </summary>
        private int _mainLengthL;

        /// <summary>
        ///     Высота платформы.
        /// </summary>
        private int _platformHeightG;

        /// <summary>
        ///     Длина платформы.
        /// </summary>
        private int _platformLengthF;

        /// <summary>
        ///     Толщина платформы.
        /// </summary>
        private int _platformThicknessT;

        /// <summary>
        ///     Ширина платформы.
        /// </summary>
        private int _slideWidthA;

        /// <summary>
        ///     Длина начала горки.
        /// </summary>
        private int _startLengthE;

        /// <summary>
        ///     Конструктор класса.
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
        ///     Высота бордюра.
        /// </summary>
        public int BorderHeightC
        {
            get => _borderHeightC;

            set
            {
                CheckParam(8, 32, value, "Высота бордюра (C)");

                _borderHeightC = value;
            }
        }

        /// <summary>
        ///     Длина конца горки.
        /// </summary>
        public int EndLengthD
        {
            get => _endLengthD;

            set
            {
                CheckParam(20, 60, value, "Длина конца горки (D)");

                _endLengthD = value;
            }
        }

        /// <summary>
        ///     Длина горки.
        /// </summary>
        public int MainLengthL
        {
            get => _mainLengthL;

            set
            {
                CheckParam(80, 240, value, "Длина горки (L)");

                _mainLengthL = value;
            }
        }

        /// <summary>
        ///     Высота платформы.
        /// </summary>
        public int PlatformHeightG
        {
            get => _platformHeightG;

            set
            {
                CheckParam(40, 160, value, "Высота платформы (G)");

                _platformHeightG = value;
            }
        }

        /// <summary>
        ///     Длина платформы.
        /// </summary>
        public int PlatformLengthF
        {
            get => _platformLengthF;

            set
            {
                CheckParam(40, 120, value, "Длина платформы (F)");

                _platformLengthF = value;
            }
        }

        /// <summary>
        ///     Ширина горки.
        /// </summary>
        public int SlideWidthA
        {
            get => _slideWidthA;

            set
            {
                CheckParam(20, 80, value, "Ширина горки (A)");

                _slideWidthA = value;
            }
        }

        /// <summary>
        ///     Длина начала горки.
        /// </summary>
        public int StartLengthE
        {
            get => _startLengthE;

            set
            {
                CheckParam(20, 60, value, "Длина начала горки (E)");

                _startLengthE = value;
            }
        }

        /// <summary>
        ///     Толщина платформы.
        /// </summary>
        public int PlatformThicknessT
        {
            get => _platformThicknessT;

            set
            {
                CheckParam(3, 10, value, "Толщина платформы (T)");

                _platformThicknessT = value;
            }
        }

        /// <summary>
        ///     Проверить параметры на граничные значения.
        /// </summary>
        /// <param name="min">Минимальные значения.</param>
        /// <param name="max">Максимальные значения.</param>
        /// <param name="value">Значение.</param>
        /// <param name="name">Название парметра.</param>
        private void CheckParam(int min, int max, int value, string name)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    name + " должна находиться в диапазоне от " +
                    min + " до " + max + ".");
            }
        }
    }
}