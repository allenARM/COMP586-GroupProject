﻿using System.Drawing;

int main()
{
    IDevice speaker = new Speaker();
    IDevice device1 = new Light();

    speaker.getLocation();

    Controller controller = new Controller();

    controller.getDevices().Add(speaker);

    Console.WriteLine(speaker.GetType());

    return 0;
}

main();

public class Controller
{
    List<IDevice> devices = new List<IDevice>();

    public List<IDevice> getDevices() { return devices; }

    private Boolean checkIfExists(IDevice device)
    {
        foreach (IDevice d in devices)
        {
            if (d.GetType() == device.GetType())
                return true;
        }
        return false;
    }
}

public interface IDevice
{
    public string getLocation();
    public void setLocation(string location);

    public Boolean getStatus();
    public void setStatus(Boolean status);
}

public abstract class ADevice
{
    private string location = "default";
    private Boolean status;

    public string getLocation() { return this.location; }
    public void setLocation(string location) { this.location = location; }

    public Boolean getStatus() { return this.status; }
    public void setStatus(Boolean status) { this.status = status; }
}


public class Speaker : ADevice, IDevice
{
    private int volume;

    public int getVolume() { return this.volume; }
    public void setVolume(int volume) { this.volume = volume; }
}

public class Light : ADevice, IDevice
{
    private Color color;
    private int brightnessLevel;

    public Color getColor() { return color; }
    public void setColor(Color color) { this.color = color; }
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
    public void setChannel(int channel) { this.channel = channel; }
}

public class Gate : ADevice, IDevice
{
    private Boolean closed;

    public void tuggle() { this.closed = !this.closed; }
    public Boolean isClosed() { return this.closed; }
}

public class Camera : ADevice, IDevice
{
    private Boolean recording;
    public void tuggle() => this.recording = !this.recording;
    public Boolean isRecording() { return this.recording; }
}

public class Outlet : ADevice, IDevice
{
    private Boolean powered;
    public void tuggle() => this.powered = !this.powered;
    public Boolean isPowered() { return this.powered; }
}