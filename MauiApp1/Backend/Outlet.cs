using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    public class Outlet : Device
    {
        //powered is true if powering other device
        private Boolean powered;

        public Outlet()
        {
            powered = false;
        }

        public void Toggle() => powered = !powered;
        public Boolean IsPowered() => powered;
    }
}
