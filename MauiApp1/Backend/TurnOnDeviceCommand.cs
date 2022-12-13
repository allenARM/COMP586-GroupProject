using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    public class TurnOnDeviceCommand : ICommand
    {
        private IDevice device;

        public TurnOnDeviceCommand(IDevice device)
        {
            this.device = device;
        }

        public void Execute()
        {
            device.Status = true;
        }
    }
}
