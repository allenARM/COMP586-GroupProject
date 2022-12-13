using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    public interface IDevice
    {
        public Boolean Status { get; set; }
        public string Location { get; set; }
    }
}
