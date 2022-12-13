
using MauiApp1.Helpers;


namespace MauiApp1.BaseDisplay
{
    internal class OutletDisplay
    {
        public static Label CreateOutlet()
        {
            var outlet = new Label
            {
                FontSize = 60,
                FontFamily = "MaterialDesignIcons",
                Text = MaterialDesignIconFonts.PowerSocketUs,
                HorizontalOptions = LayoutOptions.Center
            };

            return outlet;
        }

        public static void ToggleOutlet(Label status, Switch outletSwitch)
        {
            if (outletSwitch.IsToggled)
            {
                status.Text = "ON";
            }
            else
            {
                status.Text = "OFF";
            }

        }
    }
}
