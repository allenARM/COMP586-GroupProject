using MauiApp1.Helpers;

namespace MauiApp1.BaseDisplay
{
    internal class CameraDisplay
    {
        public static Label CreateCamera()
        {
            var outlet = new Label
            {
                FontSize = 60,
                FontFamily = "MaterialDesignIcons",
                Text = MaterialDesignIconFonts.CameraOutline,
                HorizontalOptions = LayoutOptions.Center
            };

            return outlet;
        }

        public static void ToggleCamera(Label status, Switch cameraSwitch)
        {

            if (cameraSwitch.IsToggled)
            {
                status.Text = "RECORDING";
            }
            else
            {
                status.Text = "OFF";
            }

        }
    }

}
