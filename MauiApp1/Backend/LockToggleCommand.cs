using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    public class LockToggleCommand : ICommand
    {
        private Lock _lock;

        public LockToggleCommand(Lock _lock)
        {
            this._lock = _lock;
        }

        public void Execute()
        {
            _lock.Toggle();
        }
    }
}
