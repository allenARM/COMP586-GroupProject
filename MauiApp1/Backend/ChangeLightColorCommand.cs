using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = System.Drawing.Color;

namespace _586FinalProject
{
    public class ChangeLightColorCommand : ICommand
    {
        private Light light;
        private Color color;

        public ChangeLightColorCommand(Light light, Color color)
        {
            this.light = light;
            this.color = color;
        }

        public void Execute()
        {
            light.Color = color;
        }
    }
}
