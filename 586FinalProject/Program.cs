using System.Drawing;

int main()
{
    //IDevice house = new House("House");

    House home = new House("House1");

    home.GetController().AddNewDevice(new Speaker(), home.GetRooms(), "Hallway");

    //home.GetController().CheckIfExists(new Speaker());

    Speaker speaker = (Speaker)home.GetRooms()[0].GetDevices()[0];

    Console.WriteLine(speaker.Volume);
    speaker.Volume = 99;

    speaker = (Speaker)home.GetRooms()[0].GetDevices()[0];
    Console.WriteLine(speaker.Volume);
    Console.WriteLine(speaker.GetLocation());
    return 0;
}

main();

public class Controller
{
    //List<IDevice> devices = new();
    //List<Room> rooms = new();

    //public List<IDevice> GetDevices() => devices;
    //public List<Room> GetRooms() => rooms;

    /*public Boolean CheckIfExists(object device)
    {
        foreach (object d in devices)
        {
            if (device.GetType() == d.GetType())
                return true;
        }
        return false;
    }*/

    public void AddNewDevice(IDevice device, List<Room> rooms, string location)
    {
        Boolean roomExists = false;

        device.SetLocation(location);

        foreach (var room in rooms)
        {
            if (room.GetLocation() == location)
            {
                room.AddDevice(device);
                roomExists = true;
            }
        }

        if (!roomExists)
        {
            Room newRoom = new();
            newRoom.SetLocation(location);
            newRoom.AddDevice(device);
            rooms.Add(newRoom);
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
        location = null;
    }

    public void SetLocation(string location) => this.location = location;
    public string? GetLocation() => location;
    public void AddDevice(IDevice device) => devices.Add(device);
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

    public void SetHouseName(string houseName) { this.houseName = houseName; }
    public string GetHouseName() => houseName;
    public Controller GetController() => controller;
    public List<Room> GetRooms() => rooms;
}

public interface IDevice
{
    public string GetLocation();
    public void SetLocation(string location);
}

public abstract class ADevice
{
    private string location = "default";
    //if status true means device is on
    //if status false means device is off
    private Boolean status;


    public string GetLocation() => location;
    public void SetLocation(string location) => this.location = location;

    public Boolean GetStatus() => status;
    public void SetStatus(Boolean status) => this.status = status;
}

public class Speaker : ADevice, IDevice
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

public class Light : ADevice, IDevice
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
public enum OutSideWeather { sunny, cloudy, rainy, storm, apocalypse }

public class Thermostat : ADevice, IDevice
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

public class SmartTV : ADevice, IDevice
{
    private int channel;
    private Speaker speaker;

    public SmartTV()
    {
        channel = 0;
        speaker = new();
    }

    public void SetVolume(int volume) => speaker.Volume = volume;
    public int Channel
    {
        get => channel;
        set => channel = value;
    }
    //public void SetChannel(int channel) => this.channel = channel; 
}

public class Gate : ADevice, IDevice
{
    private Boolean closed;

    public Gate()
    {
        closed = false;
    }

    public void Toggle() => closed = !closed;
    public Boolean IsClosed() => closed;
}

public class Camera : ADevice, IDevice
{
    private Boolean recording;

    public Camera()
    {
        recording = false;
    }

    public void Toggle() => recording = !recording;
    public Boolean IsRecording() => recording;
}

public class Outlet : ADevice, IDevice
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
