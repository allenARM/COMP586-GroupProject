using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    public abstract class Device : IDevice
    {
        //if status true means device is on
        //if status false means device is off
        private Boolean status;

        private string location = string.Empty;

        public Boolean Status
        {
            get => status;
            set => status = value;
        }
        public string Location
        {
            get => location;
            set => location = value;
        }
    }
}
