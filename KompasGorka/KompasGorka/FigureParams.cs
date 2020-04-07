using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompasGorka
{
    class FigureParams
    {
        private int _borderHeightC;
        private int _endLengthD;
        private int _mainLengthL;
        private int _platformHeightG;
        private int _platformLengthF;
        private int _slideWidthA;
        private int _startLengthE;

        public FigureParams(int borderHeightC,int endLengthD, int mainLengthL, 
            int platformHeightG, int platformLengthF, int slideWidthA, int startLengthE)
        {
            BorderHeightC = borderHeightC;
            EndLengthD = endLengthD;
            MainLengthL = mainLengthL;
            PlatformHeightG = platformHeightG;
            PlatformLengthF = platformLengthF;
            SlideWidthA = slideWidthA;
            StartLengthE = startLengthE;              
        }

        public int BorderHeightC {
            get => _borderHeightC;
            set 
            {
                if (value < 8 || value > 32)
                {
                    throw new ArgumentException("Значение параметра должно находиться в диапозоне от 8 до 32");
                }
                    
                _borderHeightC = value;
            } 
        }

        public int EndLengthD
        {
            get => _endLengthD;
            set
            {
                if(value < 20 || value > 60)
                {
                    throw new ArgumentException("Значение параметра должно находиться в диапозоне от 20 до 60");
                }
                _endLengthD = value;
            }
        }

        public int MainLengthL
        {
            get => _mainLengthL;
            set
            {
                if (value < 80 || value > 240)
                {
                    throw new ArgumentException("Значение параметра должно находиться в диапозоне от 80 до 240");
                }
                _mainLengthL = value;
            }
        }

        public int PlatformHeightG
        {
            get => _platformHeightG;
            set
            {
                if (value < 40 || value > 160)
                {
                    throw new ArgumentException("Значение параметра должно находиться в диапозоне от 40 до 160");
                }
                _platformHeightG = value;
            }
        }

        public int PlatformLengthF
        {
            get => _platformLengthF;
            set
            {
                if (value < 40 || value > 120)
                {
                    throw new ArgumentException("Значение параметра должно находиться в диапозоне от 40 до 120");
                }
                _platformLengthF = value;
            }
        }

        public int SlideWidthA
        {
            get => _slideWidthA;
            set
            {
                if (value < 20 || value > 80)
                {
                    throw new ArgumentException("Значение параметра должно находиться в диапозоне от 20 до 80");
                }
                _slideWidthA = value;
            }
        }

        public int StartLengthE
        {
            get => _startLengthE;
            set
            {
                if (value < 20 || value > 60)
                {
                    throw new ArgumentException("Значение параметра должно находиться в диапозоне от 20 до 60");
                }
                _startLengthE = value;
            }
        }

    }
}
