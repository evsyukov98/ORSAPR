using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompasGorka
{
    class FigureParams
    {
        private int _borderHeight;
        public int BorderHight {
            get => _borderHeight;
            set 
            {
                if (value > 8 && value < 32) 
                    return;

                _borderHeight = value;
            } 
        }
    }
}
