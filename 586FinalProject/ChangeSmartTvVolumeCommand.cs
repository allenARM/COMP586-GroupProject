using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    public class ChangeSmartTvVolumeCommand : ICommand
    {
        private SmartTv smartTv;
        private int volume;

        public ChangeSmartTvVolumeCommand(SmartTv smartTv, int volume)
        {
            this.smartTv = smartTv;
            this.volume = volume;
        }

        public void Execute()
        {
            smartTv.Volume = volume;
        }
    }
}
