using System.Drawing;

int main()
{
    //IDevice house = new House("House");

    House home = new House("HouseOne");

    //Living Room 
    home.GetController().AddNewDevice(new Speaker(), home.GetRooms(), "LivingRoom");
    home.GetController().AddNewDevice(new Speaker(), home.GetRooms(), "LivingRoom");
    home.GetController().AddNewDevice(new SmartTV(), home.GetRooms(), "LivingRoom");
    home.GetController().AddNewDevice(new Light(), home.GetRooms(), "LivingRoom");
    home.GetController().AddNewDevice(new Thermostat(), home.GetRooms(), "LivingRoom");
    home.GetController().AddNewDevice(new Outlet(), home.GetRooms(), "LivingRoom");

    //Kitchen 
    home.GetController().AddNewDevice(new Speaker(), home.GetRooms(), "Kitchen");
    home.GetController().AddNewDevice(new Light(), home.GetRooms(), "Kitchen");
    home.GetController().AddNewDevice(new Thermostat(), home.GetRooms(), "Kitchen");
    home.GetController().AddNewDevice(new Outlet(), home.GetRooms(), "Kitchen");

    //Bedroom
    home.GetController().AddNewDevice(new Speaker(), home.GetRooms(), "Bedroom");
    home.GetController().AddNewDevice(new Lock(), home.GetRooms(), "Bedroom");
    home.GetController().AddNewDevice(new SmartTV(), home.GetRooms(), "Bedroom");
    home.GetController().AddNewDevice(new Light(), home.GetRooms(), "Bedroom");
    home.GetController().AddNewDevice(new Camera(), home.GetRooms(), "Bedroom");
    home.GetController().AddNewDevice(new Thermostat(), home.GetRooms(), "Bedroom");
    home.GetController().AddNewDevice(new Outlet(), home.GetRooms(), "Bedroom");

    //home.GetController().CheckIfExists(new Speaker());

    Speaker speakerOne = (Speaker)home.GetRooms()[0].GetDevices()[0];
    Speaker speakerTwo = (Speaker)home.GetRooms()[0].GetDevices()[1];
    SmartTV smartTV = (SmartTV)home.GetRooms()[0].GetDevices()[2];
    Light light = (Light)home.GetRooms()[0].GetDevices()[3];
    Thermostat thermostat = (Thermostat)home.GetRooms()[0].GetDevices()[4];
    Outlet outlet = (Outlet)home.GetRooms()[0].GetDevices()[5];

    //Console.WriteLine(home.GetRooms()[0].GetDevices());

    Console.WriteLine($"{speakerOne.Location} {speakerOne.Volume} {speakerTwo.Volume} {smartTV.Channel} {light.Brightness} {thermostat.OutsideTemp} {outlet.IsPowered()}");

    //Console.WriteLine((Outlet)home.GetRooms()[0].GetDevices()[5])

    speakerOne.Volume = 78;
    speakerOne.Volume = 13;
    smartTV.Channel = 42;
    light.Brightness = 91;
    thermostat.OutsideTemp = 100;
    outlet.Toggle();

    Console.WriteLine($"{speakerOne.Location} {speakerOne.Volume} {speakerTwo.Volume} {smartTV.Channel} {light.Brightness} {thermostat.OutsideTemp} {outlet.IsPowered()}");

    home.GetController().RemoveDevice(outlet, home.GetRooms());

    Console.WriteLine($"{speakerOne.Location} {speakerOne.Volume} {speakerTwo.Volume} {smartTV.Channel} {light.Brightness} {thermostat.OutsideTemp} {outlet.IsPowered()}");

    /*speakerOne = (Speaker)home.GetRooms()[1].GetDevices()[0];
    light = (Light)home.GetRooms()[1].GetDevices()[1];
    thermostat = (Thermostat)home.GetRooms()[1].GetDevices()[2];
    outlet = (Outlet)home.GetRooms()[1].GetDevices()[3];

    Console.WriteLine(speakerOne.GetLocation() + " " + speakerOne.Volume + " " + light.Brightness + " " + thermostat.OutsideTemp + " " + outlet.IsPowered());*/

    /*Console.WriteLine(speakerOne.Volume);
    speaker.Volume = 99;

    speaker = (Speaker)home.GetRooms()[0].GetDevices()[0];
    Console.WriteLine(speaker.Volume);
    Console.WriteLine(speaker.GetLocation());*/


    return 0;
}

main();


public class Controller
{
    public void AddNewDevice(IDevice device, List<Room> rooms, string location)
    {
        Boolean roomExists = false;
        
        device.Location = location;

        foreach (var room in rooms)
        {
            if (room.Location == location)
            {
                room.AddDevice(device);
                roomExists = true;
            }
        }

        if(!roomExists)
        {
            Room newRoom = new();
            newRoom.Location = location;
            newRoom.AddDevice(device);
            rooms.Add(newRoom);
        }
    }

    public void RemoveDevice(IDevice device, List<Room> rooms)
    {
        foreach (var room in rooms)
        {
            if (device.Location == room.Location)
            {
                room.RemoveDevice(device);
            }
        }
    }
}

public class Room
{
    List<IDevice> devices;
    private string? location;

    public Room()
    {
        devices = new();
        location = string.Empty;
    }
    public string? Location
    {
        get => location;
        set => location = value;
    }
    //public void SetLocation(string location) => this.location = location;
    //public string? GetLocation() => location;
    public void AddDevice(IDevice device) => devices.Add(device);
    public void RemoveDevice(IDevice device) => devices.Remove(device);
    public List<IDevice> GetDevices() => devices;
}

public class House
{
    private List<Room> rooms;
    private Controller controller;
    private string houseName;
    public House(string houseName)
    {
        rooms = new();
        controller = new();
        this.houseName = houseName;
    }

    public string HouseName
    {
        get => houseName;
        set => houseName = value;
    }
    public Controller GetController() => controller;
    public List<Room> GetRooms() => rooms;
}

public interface IDevice
{
    public Boolean Status { get; set; }
    public string Location { get; set; }
}

public abstract class Device : IDevice
{
    //if status true means device is on
    //if status false means device is off
    private Boolean status;

    private string location = string.Empty;
  
    public Boolean Status
    {
        get => status;
        set => status= value;
    }
    public string Location
    {
        get => location;
        set => location = value;
    }
}

public class Speaker : Device
{
    private int volume;

    public Speaker()
    {
        this.volume = 50;
    }

    public int Volume
    {
        get => volume;

        set
        {
            if (volume >= 100)
            {
                volume = 100;
            }
            else if (volume <= 0)
            {
                volume = 0;
            }
            else
            {
                volume = value;
            }

        }
    }
}

public class Light : Device
{
    private Color color;
    private int brightness;

    public Light()
    {
        this.color = Color.WhiteSmoke;
        this.brightness = 50;
    }
    public Color Color
    {
        get => color;
        set => color = value;
    }
    public int Brightness
    {
        get => brightness;
        set => brightness = value;
    }
}

public enum ThermostatStatus { off, heat, cool }
public enum OutSideWeather { sunny, cloudy, clear, rain, storm }

public class Thermostat : Device
{
    private int insideTemp;
    private int outsideTemp;
    private int tempTarget;
    private ThermostatStatus thermostatStatus;
    private OutSideWeather outSideWeather;

    public Thermostat()
    {
        insideTemp = 65;
        outsideTemp = 80;
        tempTarget = 75;
        thermostatStatus = ThermostatStatus.heat;
        outSideWeather = OutSideWeather.cloudy;
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

    public ThermostatStatus ThermostatStatus
    {
        get => thermostatStatus;
        set => thermostatStatus = value;
    }

    public OutSideWeather OutSideWeather
    {
        get => outSideWeather;
        set => outSideWeather = value;
    }
}

public class SmartTV : Device
{
    private int channel;
    private Speaker speaker;

    public SmartTV()
    {
        channel = 0;
        speaker = new();
    }

    public int Volume
    {
        get => speaker.Volume;
        set => speaker.Volume = value;
    }
    public int Channel
    {
        get => channel;
        set => channel = value;
    }
}

public class Lock : Device
{
    private Boolean closed;

    public Lock()
    {
        closed = false;
    }

    public void Toggle() => closed = !closed; 
    public Boolean IsClosed() => closed; 
}

public class Camera : Device
{
    private Boolean recording;

    public Camera()
    {
        recording = false;
    }

    public void Toggle() => recording = !recording;
    public Boolean IsRecording() => recording; 
}

public class Outlet : Device
{
    //powered is true if powering other device
    private Boolean powered;

    public Outlet()
    {
        powered = false;
    }

    public void Toggle() => powered = !powered;
    public Boolean IsPowered() => powered;
}
