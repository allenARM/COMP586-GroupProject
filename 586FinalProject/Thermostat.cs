using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    public enum ThermostatMode { off, heat, cool }
    public enum OutsideWeather { sunny, cloudy, clear, rain, storm }

    public class Thermostat : Device
    {
        private int insideTemp;
        private int outsideTemp;
        private int tempTarget;
        private ThermostatMode thermostatMode;
        private OutsideWeather outsideWeather;

        public Thermostat()
        {
            insideTemp = 65;
            outsideTemp = 80;
            tempTarget = 75;
            thermostatMode = ThermostatMode.heat;
            outsideWeather = OutsideWeather.cloudy;
        }

        public int InsideTemp
        {
            get => insideTemp;
            set => insideTemp = value;
        }

        public int OutsideTemp
        {
            get => outsideTemp;
            set => outsideTemp = value;
        }

        public int TempTarget
        {
            get => tempTarget;
            set => tempTarget = value;
        }

        public ThermostatMode ThermostatMode
        {
            get => thermostatMode;
            set => thermostatMode = value;
        }

        public OutsideWeather OutsideWeather
        {
            get => outsideWeather;
            set => outsideWeather = value;
        }
    }

}
