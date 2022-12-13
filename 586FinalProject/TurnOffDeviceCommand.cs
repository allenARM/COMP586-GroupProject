using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    public class TurnOffDeviceCommand : ICommand
    {
        private IDevice device;

        public TurnOffDeviceCommand(IDevice device)
        {
            this.device = device;
        }

        public void Execute()
        {
            device.Status = false;
        }
    }
}
