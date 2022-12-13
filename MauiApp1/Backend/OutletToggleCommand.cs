using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    public class OutletToggleCommand : ICommand
    {
        private Outlet outlet;

        public OutletToggleCommand(Outlet outlet)
        {
            this.outlet = outlet;
        }

        public void Execute()
        {
            outlet.Toggle();
        }
    }
}
