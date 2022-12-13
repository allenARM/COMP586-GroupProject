using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    public class SmartTv : Device
    {
        private int channel;
        private Speaker speaker;

        public SmartTv()
        {
            channel = 0;
            speaker = new();
        }

        public int Volume
        {
            get => speaker.Volume;
            set => speaker.Volume = value;
        }
        public int Channel
        {
            get => channel;
            set => channel = value;
        }
    }
}
