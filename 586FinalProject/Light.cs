using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    public class Light : Device
    {
        private Color color;
        private int brightness;

        public Light()
        {
            this.color = Color.WhiteSmoke;
            this.brightness = 50;
        }
        public Color Color
        {
            get => color;
            set => color = value;
        }
        public int Brightness
        {
            get => brightness;
            set => brightness = value;
        }
    }
}
