using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    public class RemoveRoomFromHouseCommand : ICommand
    {
        private House house;
        private Room room;

        public RemoveRoomFromHouseCommand(House house, Room room)
        {
            this.house = house;
            this.room = room;
        }

        public void Execute()
        {
            house.RemoveRoom(room);
        }
    }
}
