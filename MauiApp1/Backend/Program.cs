using _586FinalProject;

using MauiApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _586FinalProject
{
    public static class Globals
    {
        public static House house = new House("My House");

        public static Room livingRoom = new Room("Living Room");
        public static Room kitchen = new Room("Kitchen");
        public static Room bedroom = new Room("Bedroom");
        public static Room otherRoom = new Room("Other");

        public static void run()
        {
            AddRoomToHouseCommand addRoomToHouseCommand = new AddRoomToHouseCommand(house, livingRoom);
            Controller controller = new Controller(addRoomToHouseCommand);

            controller.ExecuteCommand();

            addRoomToHouseCommand = new AddRoomToHouseCommand(house, kitchen);
            controller = new Controller(addRoomToHouseCommand);
            controller.ExecuteCommand();

            addRoomToHouseCommand = new AddRoomToHouseCommand(house, bedroom);
            controller = new Controller(addRoomToHouseCommand);
            controller.ExecuteCommand();

            addRoomToHouseCommand = new AddRoomToHouseCommand(house, otherRoom);
            controller = new Controller(addRoomToHouseCommand);
            controller.ExecuteCommand();
        }
    }
}


 





















