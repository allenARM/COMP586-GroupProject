using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    public class Room
    {
        List<IDevice> devices;
        private string? location;

        public Room(string location)
        {
            devices = new();
            this.location = location;
        }
        public string? Location
        {
            get => location;
            set => location = value;
        }
     
        public void AddDevice(IDevice device) => devices.Add(device);
        public void RemoveDevice(IDevice device) => devices.Remove(device);
        public List<IDevice> GetDevices() => devices;
    }
}
