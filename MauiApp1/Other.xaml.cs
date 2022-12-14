using MauiApp1.BaseDisplay;
using Syncfusion.Maui.Gauges;
using Syncfusion.Maui.Sliders;
using _586FinalProject;

namespace MauiApp1;
public partial class Other : ContentPage
{
    public Other()
    {
        InitializeComponent();
    }

    private int BulbIndex = 1;                                /* device index */
    private int SpeakerIndex = 1;
    private int CameraIndex = 1;
    private int OutletIndex = 1;
    private int ThermIndex = 1;
    private int TvIndex = 1;
    private int LockIndex = 1;

    public int GetBulbIndex() => BulbIndex;                   /* get device index */
    public int GetSpeakerIndex() => SpeakerIndex;
    public int GetCameraIndex() => CameraIndex;
    public int GetOutletIndex() => OutletIndex;
    public int GetThermIndex() => ThermIndex;
    public int GetTvIndex() => TvIndex;
    public int GetLockIndex() => LockIndex;


    void OnEntryCompleted(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
        label1.Text = text;
        
    }

    
    public void OtherLight(object sender, EventArgs e)
    {
        Light light = new Light();
        string name = "Light Bulb";
        var l = buttons.DeviceLabel(GetBulbIndex(), name);           /* Create device label */
        BulbIndex++;                                                  /* Increment Index */

        var bulb = LightBulbDisplay.createLightBulb();               /* create lightbulb */
        var del = buttons.delete();                                  /* create delete */
        var s = buttons.slide();                                     /* create toggle */

        del.Clicked += OnClick;                                 /* register event handlers */
        s.ValueChanged += OnValueChanged;

        A.Add(del);                                             /* push onto display stack */
        A.Add(l);
        A.Add(bulb);
        A.Add(s);
        AddDeviceToRoomCommand addDeviceToRoomCommand = new AddDeviceToRoomCommand(Globals.otherRoom, light);
        Controller controller = new Controller(addDeviceToRoomCommand);
        controller.ExecuteCommand();

        void OnValueChanged(object sender, SliderValueChangedEventArgs e)   /* toggle light  */
        {
            double value = e.NewValue;
            LightBulbDisplay.toggleLight(value, bulb);
            light.Brightness = value;
        }

        void OnClick(object sender, EventArgs e)      /* device deleted, pop off display stack */
        {
            int i = A.IndexOf(del);

            A.RemoveAt(i + 3);
            A.RemoveAt(i + 2);
            A.RemoveAt(i + 1);
            A.RemoveAt(i);
            RemoveDeviceFromRoomCommand removeDeviceFromRoomCommand = new RemoveDeviceFromRoomCommand(Globals.otherRoom, light);
            Controller controller = new Controller(removeDeviceFromRoomCommand);
            controller.ExecuteCommand();
        }

    }
    private void OtherSpeaker(object sender, EventArgs e)
    {
        Speaker speaker1 = new Speaker();
        string name = "Speaker";
        var l = buttons.DeviceLabel(GetSpeakerIndex(), name);         /* Create device label */
        SpeakerIndex++;                                                 /* Increment Index */

        var speaker = SpeakerDisplay.createSpeaker();                /* create speakr */
        var del = buttons.delete();                                  /* create delete */
        var s = buttons.slide();                                      /* create toggle */

        del.Clicked += OnClick;                                    /* register event handlers*/
        s.ValueChanged += OnValueChanged;

        B.Add(del);                                               /* push onto display stack */
        B.Add(l);
        B.Add(speaker);
        B.Add(s);
        AddDeviceToRoomCommand addDeviceToRoomCommand = new AddDeviceToRoomCommand(Globals.otherRoom, speaker1);
        Controller controller = new Controller(addDeviceToRoomCommand);
        controller.ExecuteCommand();

        void OnValueChanged(object sender, SliderValueChangedEventArgs e)   /* toggle volume */
        {
            double value = e.NewValue;
            SpeakerDisplay.toggleSpeaker(value, speaker);
            speaker1.Volume = value;
        }

        void OnClick(object sender, EventArgs e)                /* device deleted, pop off display stack */
        {
            int i = B.IndexOf(del);

            B.RemoveAt(i + 3);
            B.RemoveAt(i + 2);
            B.RemoveAt(i + 1);
            B.RemoveAt(i);
            RemoveDeviceFromRoomCommand removeDeviceFromRoomCommand = new RemoveDeviceFromRoomCommand(Globals.otherRoom, speaker1);
            Controller controler = new Controller(removeDeviceFromRoomCommand);
            controler.ExecuteCommand();
        }
    }

    private void OtherThermostat(object sender, EventArgs e)
    {
        Thermostat thermostat1 = new Thermostat();
        string name = "Thermostat";
        var l = buttons.DeviceLabel(GetThermIndex(), name);           /* create device label */
        ThermIndex++;                                               /* increment device index */

        GaugeAnnotation gaugeAnnotation = new GaugeAnnotation();
        gaugeAnnotation.Content = new Label
        {
            Text = "72 °F",
            TextColor = Colors.Black,                               /* creating thermostat components */
            FontAttributes = FontAttributes.Bold,
            FontSize = 20
        };

        var thermostat = new SfRadialGauge();
        var coolToggle = ThermostatDisplay.markerpointer();
        var heatToggle = ThermostatDisplay.markerpointer2();
        var radialAxis = ThermostatDisplay.radialAxis();

        thermostat.HeightRequest = 230;                             /* putting thermostat together */
        thermostat.WidthRequest = 280;
        thermostat.Axes.Add(radialAxis);

        radialAxis.Annotations.Add(gaugeAnnotation);
        radialAxis.Pointers.Add(coolToggle);
        radialAxis.Pointers.Add(heatToggle);

        var del = buttons.delete();
        var off = new Label();
        var CoolSwitch = new Switch();
        var HeatSwitch = new Switch();


        C.Add(del);                                              /* push to display stack */
        C.Add(l);
        C.Add(thermostat);
        C.Add(off);
        C.Add(CoolSwitch);
        C.Add(HeatSwitch);
        AddDeviceToRoomCommand addDeviceToRoomCommand = new AddDeviceToRoomCommand(Globals.otherRoom, thermostat1);
        Controller controller = new Controller(addDeviceToRoomCommand);
        controller.ExecuteCommand();

        del.Clicked += OnClick;                                   /* register event handlers*/
        coolToggle.ValueChanged += CoolToggle_ValueChanged;
        heatToggle.ValueChanged += HeatToggle_ValueChanged;

        void OnClick(object sender, EventArgs e)                 /* device delete, pop off display stack */
        {
            int i = C.IndexOf(del);

            C.RemoveAt(i + 5);
            C.RemoveAt(i + 4);
            C.RemoveAt(i + 3);
            C.RemoveAt(i + 2);
            C.RemoveAt(i + 1);
            C.RemoveAt(i);
            RemoveDeviceFromRoomCommand removeDeviceFromRoomCommand = new RemoveDeviceFromRoomCommand(Globals.otherRoom, thermostat1);
            Controller controller = new Controller(removeDeviceFromRoomCommand);
            controller.ExecuteCommand();
        }

        void CoolToggle_ValueChanged(object sender, Syncfusion.Maui.Gauges.ValueChangedEventArgs e)   /* toggle cool */
        {
            double value = e.Value;
            ThermostatDisplay.toggleCool(value, off, CoolSwitch, HeatSwitch);
            thermostat1.ThermostatMode = ThermostatMode.cool;
        }

        void HeatToggle_ValueChanged(object sender, Syncfusion.Maui.Gauges.ValueChangedEventArgs e)   /* toggle head */
        {
            double value = e.Value;
            ThermostatDisplay.toggleHeat(value, off, HeatSwitch, CoolSwitch);
            thermostat1.ThermostatMode = ThermostatMode.heat;
        }
    }

    public void OtherTv(object sender, EventArgs e)
    {
        SmartTv tv = new SmartTv();
        string name = "Tv";
        var l = buttons.DeviceLabel(GetTvIndex(), name);           /* create device label */
        TvIndex++;                                                  /* increment device index */

        var Tv = TvDisplay.createTv();                           /*creating object */
        var del = buttons.delete();
        var slider = buttons.slide();
        var volume = new Label();
        var channel = TvDisplay.channel();

        D.Add(del);                                              /* displaying objects */
        D.Add(l);
        D.Add(Tv);
        D.Add(volume);
        D.Add(slider);
        D.Add(channel);
        AddDeviceToRoomCommand addDeviceToRoomCommand = new AddDeviceToRoomCommand(Globals.otherRoom, tv);
        Controller controller = new Controller(addDeviceToRoomCommand);
        controller.ExecuteCommand();

        volume.HorizontalOptions = LayoutOptions.Center;              /* event handlers */
        slider.ValueChanged += OnValueChanged;
        del.Clicked += OnClick;

        void OnClick(object sender, EventArgs e)                 /* device delete, pop off display stack */
        {
            int i = D.IndexOf(del);

            D.RemoveAt(i + 5);
            D.RemoveAt(i + 4);
            D.RemoveAt(i + 3);
            D.RemoveAt(i + 2);
            D.RemoveAt(i + 1);
            D.RemoveAt(i);
            RemoveDeviceFromRoomCommand removeDeviceFromRoomCommand = new RemoveDeviceFromRoomCommand(Globals.otherRoom, tv);
            Controller controller = new Controller(removeDeviceFromRoomCommand);
            controller.ExecuteCommand();
        }

        void OnValueChanged(object sender, SliderValueChangedEventArgs e)   /* toggle light  */
        {
            double value = e.NewValue;
            volume.Text = value.ToString("F0");
            tv.Volume = value;
        }
    }
    private void OtherOutlet(object sender, EventArgs e)
    {
        Outlet outlet1 = new Outlet();
        string name = "Outlet";
        var l = buttons.DeviceLabel(GetOutletIndex(), name);           /*create label */
        OutletIndex++;                                                /* increment device index */

        var outlet = OutletDisplay.CreateOutlet();
        var del = buttons.delete();
        var status = new Label();
        var toggle = new Switch();
        status.Text = "OFF";

        toggle.Toggled += OnToggled;                             /* event handler */
        del.Clicked += OnClick;

        E.Add(del);                                               /* push to display stack */
        E.Add(l);
        E.Add(status);
        E.Add(outlet);
        E.Add(toggle);
        AddDeviceToRoomCommand addDeviceToRoomCommand = new AddDeviceToRoomCommand(Globals.otherRoom, outlet1);
        Controller controller = new Controller(addDeviceToRoomCommand);
        controller.ExecuteCommand();

        void OnClick(object sender, EventArgs e)                 /* device delete, pop off display stack */
        {
            int i = E.IndexOf(del);

            E.RemoveAt(i + 4);
            E.RemoveAt(i + 3);
            E.RemoveAt(i + 2);
            E.RemoveAt(i + 1);
            E.RemoveAt(i);
            RemoveDeviceFromRoomCommand removeDeviceFromRoomCommand = new RemoveDeviceFromRoomCommand(Globals.otherRoom, outlet1);
            Controller controller = new Controller(removeDeviceFromRoomCommand);
            controller.ExecuteCommand();
        }

        void OnToggled(object sender, ToggledEventArgs e)        /* toggle */
        {
            OutletDisplay.ToggleOutlet(status, toggle);         /* toggle returns true or false, status display status*/
            outlet1.Toggle();
        }

    }
    private void OtherCamera(object sender, EventArgs e)
    {
        Camera camera1 = new Camera();
        string name = "Camera";
        var l = buttons.DeviceLabel(GetCameraIndex(), name);           /* create label */
        CameraIndex++;                                                 /* increment device index */

        var camera = CameraDisplay.CreateCamera();
        var del = buttons.delete();
        var status = new Label();
        var toggle = new Switch();
        status.Text = "OFF";

        toggle.Toggled += OnToggled;                                /* event handler */
        del.Clicked += OnClick;

        F.Add(del);                                                 /*push to display stack */
        F.Add(l);
        F.Add(status);
        F.Add(camera);
        F.Add(toggle);
        AddDeviceToRoomCommand addDeviceToRoomCommand = new AddDeviceToRoomCommand(Globals.otherRoom, camera1);
        Controller controller = new Controller(addDeviceToRoomCommand);
        controller.ExecuteCommand();

        void OnClick(object sender, EventArgs e)                 /* device delete, pop off display stack */
        {
            int i = F.IndexOf(del);

            F.RemoveAt(i + 4);
            F.RemoveAt(i + 3);
            F.RemoveAt(i + 2);
            F.RemoveAt(i + 1);
            F.RemoveAt(i);
            RemoveDeviceFromRoomCommand removeDeviceFromRoomCommand = new RemoveDeviceFromRoomCommand(Globals.otherRoom, camera1);
            Controller controller = new Controller(removeDeviceFromRoomCommand);
            controller.ExecuteCommand();
        }

        void OnToggled(object sender, ToggledEventArgs e)            /* toggle */
        {
            CameraDisplay.ToggleCamera(status, toggle);              /* toggle is true or false, status displays status*/
            camera1.Toggle();
        }

    }
    private void OtherLock(object sender, EventArgs e)
    {
        Lock lock1 = new Lock();
        string name = "Lock";
        var l = buttons.DeviceLabel(GetLockIndex(), name);         /*create label */
        LockIndex++;                                                /* increment device index */

        var lockk = LockDisplay.CreateLock();
        var del = buttons.delete();
        var status = new Label();
        var toggle = new Switch();
        status.Text = "ClOSED";

        toggle.Toggled += OnToggled;                             /* event handler */
        del.Clicked += OnClick;

        G.Add(del);                                               /* push to display stack */
        G.Add(l);
        G.Add(status);
        G.Add(lockk);
        G.Add(toggle);
        AddDeviceToRoomCommand addDeviceToRoomCommand = new AddDeviceToRoomCommand(Globals.otherRoom, lock1);
        Controller controller = new Controller(addDeviceToRoomCommand);
        controller.ExecuteCommand();

        void OnClick(object sender, EventArgs e)                 /* device delete, pop off display stack */
        {
            int i = G.IndexOf(del);

            G.RemoveAt(i + 4);
            G.RemoveAt(i + 3);
            G.RemoveAt(i + 2);
            G.RemoveAt(i + 1);
            G.RemoveAt(i);
            RemoveDeviceFromRoomCommand removeDeviceFromRoomCommand = new RemoveDeviceFromRoomCommand(Globals.otherRoom, lock1);
            Controller controller = new Controller(removeDeviceFromRoomCommand);
            controller.ExecuteCommand();
        }

        void OnToggled(object sender, ToggledEventArgs e)        /* toggle */
        {
            LockDisplay.ToggleLock(status, toggle);         /* toggle returns true or false, status display status*/
            lock1.Toggle();
        }

    }

}