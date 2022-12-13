using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    public class ThermostatOutsideWeatherCommand : ICommand
    {
        private Thermostat thermostat;
        private OutsideWeather outsideWeather;

        public ThermostatOutsideWeatherCommand(Thermostat thermostat, OutsideWeather outsideWeather)
        {
            this.thermostat = thermostat;
            this.outsideWeather = outsideWeather;
        }

        public void Execute()
        {
            thermostat.OutsideWeather = outsideWeather;
        }
    }
}
