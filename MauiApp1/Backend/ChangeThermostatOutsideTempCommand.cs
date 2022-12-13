using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    public class ChangeThermostatOutsideTempCommand : ICommand
    {
        private Thermostat thermostat;
        private int temperature;

        public ChangeThermostatOutsideTempCommand(Thermostat thermostat, int temperature)
        {
            this.thermostat = thermostat;
            this.temperature = temperature;
        }

        public void Execute()
        {
            thermostat.OutsideTemp = temperature;
        }
    }
}
