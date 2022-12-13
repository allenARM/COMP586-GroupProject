using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    public class ChangeSmartTvChannelCommand : ICommand
    {
        private SmartTv smartTv;
        private int channel;

        public ChangeSmartTvChannelCommand(SmartTv smartTv, int channel)
        {
            this.smartTv = smartTv;
            this.channel = channel;
        }

        public void Execute()
        {
            smartTv.Channel = channel;
        }
    }
}
