
using MauiApp1.Helpers;



namespace MauiApp1.BaseDisplay
{
    internal class LightBulbDisplay
    {

        public static Label createLightBulb()      /*CREATES AND RETURNS LIGHTBULB ICON*/
        {
            var bulb = new Label
            {
                FontSize = 30,
                FontFamily = "MaterialDesignIcons",
                Text = MaterialDesignIconFonts.LightbulbOnOutline,
                HorizontalOptions = LayoutOptions.Center
            };

            return bulb;

        }

        public static void toggleLight(double value, Label bulb)
        {
            if (value == 0)
            {
                bulb.Text = MaterialDesignIconFonts.LightbulbOnOutline;
            }
            if (value > 0 && value < 40)
            {
                bulb.Text = MaterialDesignIconFonts.LightbulbOn40;
            }
            if (value > 40 && value < 60)
            {
                bulb.Text = MaterialDesignIconFonts.LightbulbOn60;
            }
            if (value > 60 && value < 80)
            {
                bulb.Text = MaterialDesignIconFonts.LightbulbOn80;
            }
            if (value == 100)
            {
                bulb.Text = MaterialDesignIconFonts.LightbulbOn;

            }

        }
    }
}

