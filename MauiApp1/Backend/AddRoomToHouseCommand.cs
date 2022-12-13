using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    public class AddRoomToHouseCommand : ICommand
    {
        private House house;
        private Room room;

        public AddRoomToHouseCommand(House house, Room room)
        {
            this.house = house;
            this.room = room;
        }

        public void Execute()
        {
            house.AddRoom(room);
        }
    }
}
