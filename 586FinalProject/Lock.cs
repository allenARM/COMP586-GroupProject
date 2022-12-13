using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    public class Lock : Device
    {
        private Boolean closed;

        public Lock()
        {
            closed = false;
        }

        public void Toggle() => closed = !closed;
        public Boolean IsClosed() => closed;
    }
}
