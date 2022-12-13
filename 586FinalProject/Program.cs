using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _586FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House("My House");

            Room room = new Room("Living Room");

            //Adding the room to the house.
            
            AddRoomToHouseCommand addRoomToHouseCommand = new AddRoomToHouseCommand(house, room);

            Controller controller = new Controller(addRoomToHouseCommand);

            controller.ExecuteCommand();

            Console.WriteLine(house.GetRooms()[0].Location);

            //Adding a light to the room.

            Light light = new Light();

            AddDeviceToRoomCommand addDeviceToRoomCommand = new AddDeviceToRoomCommand(room, light);

            controller = new Controller(addDeviceToRoomCommand);

            controller.ExecuteCommand();

            Console.WriteLine(house.GetRooms()[0].GetDevices()[0].GetType());

            //Change light brightness

            ChangeLightBrightnessCommand changeLightBrightnessCommand = new ChangeLightBrightnessCommand(light, 75);

            controller = new Controller(changeLightBrightnessCommand);

            controller.ExecuteCommand();

            Console.WriteLine(((Light)house.GetRooms()[0].GetDevices()[0]).Brightness);

        }
    }
}



















