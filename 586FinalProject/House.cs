using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    public class House
    {
        private List<Room> rooms;
        //private Controller controller;
        private string houseName;
        public House(string houseName)
        {
            rooms = new();
            //controller = new();
            this.houseName = houseName;
        }

        public string HouseName
        {
            get => houseName;
            set => houseName = value;
        }

        public void AddRoom(Room room) => rooms.Add(room);
        public void RemoveRoom(Room room) => rooms.Remove(room);

        //public Controller GetController() => controller;
        public List<Room> GetRooms() => rooms;
    }
}
