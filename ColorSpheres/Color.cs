using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Color
    {
        private readonly byte _red;
        private readonly byte _green;
        private readonly byte _blue;
        private readonly byte _alpha;


        public Color(byte red, byte green, byte blue, byte alpha)
        {
            _red = red;
            _green = green;
            _blue = blue;
            _alpha = alpha;
        }

        public Color(byte red, byte green, byte blue)
        {
            _red = red;
            _blue = blue;
            _green = green;
            _alpha = 255;
        }

        public byte GetRed => _red;

        public byte GetBlue => _blue;

        public byte GetGreen => _green;

        public byte GetAlpha => _alpha;


        public byte GetGrey() => (byte)((_red + _blue + _green) / 3);





    }
}