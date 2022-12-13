using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    public class RemoveDeviceFromRoomCommand : ICommand
    {
        private Room room;
        private IDevice device;

        public RemoveDeviceFromRoomCommand(Room room, IDevice device)
        {
            this.room = room;
            this.device = device;
        }

        public void Execute()
        {
            room.RemoveDevice(device);
        }
    }
}
