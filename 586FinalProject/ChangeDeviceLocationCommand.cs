using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    public class ChangeDeviceLocationCommand : ICommand
    {
        private IDevice device;
        public string location;

        public ChangeDeviceLocationCommand(IDevice device, string location)
        {
            this.device = device;
            this.location = location;
        }

        public void Execute()
        {
            device.Location = location;
        }
    }
}
