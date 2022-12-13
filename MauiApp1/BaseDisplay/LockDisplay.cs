using MauiApp1.Helpers;

namespace MauiApp1.BaseDisplay
{
    internal class LockDisplay
    {
        public static Label CreateLock()
        {
            var outlet = new Label
            {
                FontSize = 60,
                FontFamily = "MaterialDesignIcons",
                Text = MaterialDesignIconFonts.LockOutline,
                HorizontalOptions = LayoutOptions.Center
            };

            return outlet;
        }

        public static void ToggleLock(Label status, Switch outletSwitch)
        {
            if (outletSwitch.IsToggled)
            {
                status.Text = "OPEN";
            }
            else
            {
                status.Text = "CLOSED";
            }

        }
    }
}
