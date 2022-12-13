using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    public class ChangeLightBrightnessCommand : ICommand
    {
        private Light light;
        private int brightness;

        public ChangeLightBrightnessCommand(Light light, int brightness)
        {
            this.light = light;
            this.brightness = brightness;
        }

        public void Execute()
        {
            light.Brightness = brightness;  
        }
    }
}
