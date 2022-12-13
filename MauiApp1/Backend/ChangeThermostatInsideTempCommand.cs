using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    public class ChangeThermostatInsideTempCommand : ICommand
    {
        private Thermostat thermostat;
        private int temperature;

        public ChangeThermostatInsideTempCommand(Thermostat thermostat, int temperature)
        {
            this.thermostat = thermostat;
            this.temperature = temperature;
        }

        public void Execute()
        {
            thermostat.InsideTemp = temperature;
        }
    }
}
