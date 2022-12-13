using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    public class ChangeSpeakerVolumeCommand : ICommand
    {
        private Speaker speaker;
        private int volume;

        public ChangeSpeakerVolumeCommand(Speaker speaker, int volume)
        {
            this.speaker = speaker;
            this.volume = volume;
        }

        public void Execute()
        {
            speaker.Volume = volume;
        }
    }
}
