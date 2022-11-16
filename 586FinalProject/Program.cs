using System.Drawing;

int main()
{
	House home = new House("House1");

	home.getController().addNewDevice(new Speaker(), "Hallway");

	home.getController().checkIfExists(new Speaker());

	Speaker speaker = (Speaker)home.getController().getDevices()[0];

	Console.WriteLine(speaker.getVolume());
	speaker.setVolume(99);
	speaker = (Speaker)home.getController().getDevices()[0];
	Console.WriteLine(speaker.getVolume());
	Console.WriteLine(speaker.getLocation());
	return 0;
}

main();

public class Controller
{
	List<IDevice> devices = new List<IDevice>();

	List<Room> rooms = new List<Room>();

	public List<IDevice> getDevices() { return devices; }

	public List<Room> getRooms() { return rooms; }

	public Boolean checkIfExists(Object device)
	{
		foreach (Object d in devices)
		{
			if (d.GetType() == d.GetType())
				return true;
		}
		return false;
	}

	public void addNewDevice(IDevice device, string location)
	{
		device.setLocation(location);
		devices.Add(device);

		Room addToTheRoom = getRoom(location);
		if (addToTheRoom != null)
		{
			addToTheRoom.addDevice(device);
		}
		else
		{
			Room room = new Room();
			room.setLocation(location);
			rooms.Add(room);
			room.addDevice(device);
		}

		Room getRoom(string location)
		{
			foreach (var r in rooms)
			{
				if (r.getLocation() == location)
					return r;
			}
			return null;
		}
	}
}

public class Room
{
	List<IDevice> devices = new List<IDevice>();
	private string location;

	public void setLocation(string location) { this.location = location; }
	public string getLocation() { return this.location; }

	public void addDevice(IDevice device) { this.devices.Add(device); } 
	public Object getDevices() { return this.devices; }
}

public class House
{
	public House(string houseName)
	{
		this.houseName = houseName;
	}
	private Controller controller = new Controller();
	private string houseName;

	public void setHouseName(string housename) { this.houseName = houseName; }

	public string getHouseName() { return this.houseName; }

	public Controller getController() { return this.controller; }
}

public interface IDevice
{
	public string getLocation();
	public void setLocation(string location);
}

public abstract class ADevice
{
	private string location = "default";
	//if status true means device is on
	//if status false means device is off
	private Boolean status;

	public string getLocation() { return this.location; }
	public void setLocation(string location) { this.location = location; }

	public Boolean getStatus() { return this.status; }
	public void setStatus(Boolean status) { this.status = status; }
}

public class Speaker : ADevice, IDevice
{
	private int volume;

	public Speaker()
	{
		this.volume = 50;
	}

	public int getVolume() { return this.volume; }
	public void setVolume(int volume)
	{
		if (volume >= 100)
			this.volume = 100;
		else if (volume <= 0)
			this.volume = 0;
		else
			this.volume = volume;
	}
}

public class Light : ADevice, IDevice
{
	private Color color;
	private int brightnessLevel;

	public Light()
	{
		this.color = Color.WhiteSmoke;
		this.brightnessLevel = 50;
	}

	public Color getColor() { return color; }
	public void setColor(Color color) { this.color = color; }

	public int getBrightness() { return this.brightnessLevel; }
	public void setBrightness(int brightnessLevel) => this.brightnessLevel = brightnessLevel;
}

public enum ThermostatStatus { off, heat, cool}
public enum OutSideWeather { sunny, cloudy, rainy, storm, apocalypse }

public class Thermostat : ADevice, IDevice
{
	private int insideTemp;
	private int outsideTemp;
	private int tempTarget;
	private ThermostatStatus thermostatStatus;
	private OutSideWeather outSideWeather;

	public void setInsideTemp(int temp) => this.insideTemp = temp;
	public void setOutsideTemp(int temp) => this.outsideTemp = temp;
	public void setTempTarget(int temp) => this.tempTarget = temp;
	public void setThermostatStatus(ThermostatStatus tss) => this.thermostatStatus = tss;
	public void setOutSideWeather(OutSideWeather osw) => this.outSideWeather = osw;

	public int getInsideTemp() { return this.insideTemp; }
	public int getOutsideTemp() { return this.outsideTemp; }
	public int getTempTarget() { return this.tempTarget; }
	public ThermostatStatus GetThermostatStatus() { return this.thermostatStatus; }
	public OutSideWeather GetOutSideWeather() { return this.outSideWeather; }
}

public class SmartTV : ADevice, IDevice
{
	private int channel;
	private Speaker speaker;

	public SmartTV()
	{
		this.channel = 0;
		this.speaker = new Speaker();
	}

	public void setVolume(int volume) { speaker.setVolume(volume); }
	public void setChannel(int channel) { this.channel = channel; }
}

public class GateController : ADevice, IDevice
{
	private Boolean closed;

	public GateController()
	{
		this.closed = false;
	}

	public void toggle() { this.closed = !this.closed; }
	public Boolean isClosed() { return this.closed; }
}

public class Camera : ADevice, IDevice
{
	private Boolean recording;

	public Camera()
	{
		this.recording = false;
	}

	public void toggle() => this.recording = !this.recording;
	public Boolean isRecording() { return this.recording; }
}

public class Outlet : ADevice, IDevice
{
	//powered is true if powering other device
	private Boolean powered;

	public Outlet()
	{
		this.powered = false;
	}

	public void toggle() => this.powered = !this.powered;
	public Boolean isPowered() { return this.powered; }
}