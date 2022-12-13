
using MauiApp1.Helpers;



namespace MauiApp1.BaseDisplay
{
    internal class SpeakerDisplay
    {

        public static Label createSpeaker()      /*CREATES AND RETURNS SPEAKER ICON*/
        {
            var speaker = new Label
            {
                FontSize = 30,
                FontFamily = "MaterialDesignIcons",
                Text = MaterialDesignIconFonts.VolumeOff,
                HorizontalOptions = LayoutOptions.Center
            };

            return speaker;

        }

        public static void toggleSpeaker(double value, Label bulb)     /*TOGGLES SPEAKER ICON*/
        {
            if (value == 0)
            {
                bulb.Text = MaterialDesignIconFonts.VolumeOff;
            }
            if (value > 0 && value < 33)
            {
                bulb.Text = MaterialDesignIconFonts.VolumeLow;
            }
            if (value > 33 && value < 66)
            {
                bulb.Text = MaterialDesignIconFonts.VolumeMedium;
            }
            if (value > 66 && value < 100)
            {
                bulb.Text = MaterialDesignIconFonts.VolumeHigh;
            }

        }
    }
}
