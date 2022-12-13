using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    public class SmartTv : Device
    {
        private double channel;
        private Speaker speaker;

        public SmartTv()
        {
            channel = 0;
            speaker = new();
        }

        public double Volume
        {
            get => speaker.Volume;
            set => speaker.Volume = value;
        }
        public double Channel
        {
            get => channel;
            set => channel = value;
        }
    }
}
