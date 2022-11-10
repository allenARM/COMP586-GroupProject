using System.Drawing;

int main()
{
    Speaker speaker = new Speaker();
    Light light = new Light();

    speaker.getLocation();
    speaker.getVolume();
    speaker.setVolume(10);

    Controller controller = new Controller();

    controller.getDevices().Add(speaker);

    Console.WriteLine(speaker.GetType());

    return 0;
}

main();

public class Controller
{
    List<Object> devices = new List<Object>();

    //List<Room> rooms = new List<Room>();

    public List<Object> getDevices() { return devices; }

    private Boolean checkIfExists(Object device)
    {
        foreach (Object d in devices)
        {
            if (d.GetType() == d.GetType())
                return true;
        }
        return false;
    }
}

public class Room
{
    List<Object> devices = new List<Object>();
    private string location;
}

//public interface IDevice: ISpeaker, ILight
//{
//    public string getLocation();
//    public void setLocation(string location);

//    public Boolean getStatus();
//    public void setStatus(Boolean status);
//}

//public interface ISpeaker
//{
//    public int getVolume();
//    public void setVolume(int volume);
//}

//public interface ILight
//{
//    public Color getColor();
//    public void setColor(Color color);
//}

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

public class Speaker : ADevice
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

public class Light : ADevice
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

public class Thermostat : ADevice
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

public class SmartTV : ADevice
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

public class GateController : ADevice
{
    private Boolean closed;

    public GateController()
    {
        this.closed = false;
    }

    public void toggle() { this.closed = !this.closed; }
    public Boolean isClosed() { return this.closed; }
}

public class Camera : ADevice
{
    private Boolean recording;

    public Camera()
    {
        this.recording = false;
    }

    public void toggle() => this.recording = !this.recording;
    public Boolean isRecording() { return this.recording; }
}

public class Outlet : ADevice
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