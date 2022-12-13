using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    public class ThermostatModeCommand : ICommand
    {
        private Thermostat thermostat;
        private ThermostatMode thermostatMode;

        public ThermostatModeCommand(Thermostat thermostat, ThermostatMode thermostatMode)
        {
            this.thermostat = thermostat;
            this.thermostatMode = thermostatMode;
        }

        public void Execute()
        {
            thermostat.ThermostatMode = thermostatMode;
        }
    }
}
