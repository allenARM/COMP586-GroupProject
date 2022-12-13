using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    public class Speaker : Device
    {
        private int volume;

        public Speaker()
        {
            this.volume = 50;
        }

        public int Volume
        {
            get => volume;

            set
            {
                if (volume >= 100)
                {
                    volume = 100;
                }
                else if (volume <= 0)
                {
                    volume = 0;
                }
                else
                {
                    volume = value;
                }

            }
        }
    }
}
