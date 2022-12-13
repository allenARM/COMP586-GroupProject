using Syncfusion.Maui.Gauges;


namespace MauiApp1.BaseDisplay
{
    internal class ThermostatDisplay
    {


        public static ShapePointer markerpointer()
        {
            ShapePointer markerPointer = new ShapePointer();
            markerPointer.Fill = new SolidColorBrush(Colors.CornflowerBlue);    /* COOL  */
            markerPointer.IsInteractive = true;
            markerPointer.Value = 75;
            markerPointer.Offset = -30;

            return markerPointer;

        }
        public static ShapePointer markerpointer2()
        {
            ShapePointer markerPointer = new ShapePointer();
            markerPointer.Fill = new SolidColorBrush(Colors.IndianRed);    /* HEAT */
            markerPointer.IsInteractive = true;
            markerPointer.Value = 60;
            markerPointer.Offset = -30;

            return markerPointer;

        }
        public static RadialAxis radialAxis()
        {
            RadialAxis radialAxis = new RadialAxis();
            radialAxis.ShowTicks = true;
            radialAxis.AxisLineStyle.Fill = new SolidColorBrush(Colors.LightGrey);
            radialAxis.AxisLineStyle.Thickness = 5;
            radialAxis.Minimum = -10;
            radialAxis.Maximum = 120;
            return radialAxis;
        }

        public static void toggleCool(double value, Label off, Switch ThermostatSwitch, Switch ThermostatSwitch2)
        {

            if (!ThermostatSwitch.IsToggled)
            {

                off.Text = "OFF";
            }

            if (ThermostatSwitch.IsToggled && !ThermostatSwitch2.IsToggled)
            {
                if (value < 72)
                {

                    off.Text = "Cool On";

                }
                if (value > 72)
                {

                    off.Text = "Cool Off";

                }

            }

        }
        public static void toggleHeat(double value, Label off, Switch ThermostatSwitch, Switch ThermostatSwitch2)
        {

            if (ThermostatSwitch.IsToggled && !ThermostatSwitch2.IsToggled)
            {
                if (value > 72)
                {

                    off.Text = "Heat On";

                }
                if (value < 72)
                {

                    off.Text = "Heat Off";

                }

            }
            if (!ThermostatSwitch.IsToggled)
            {

                off.Text = "OFF";
            }

        }
    }
}
