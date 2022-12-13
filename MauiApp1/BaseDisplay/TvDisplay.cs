using MauiApp1.Helpers;

namespace MauiApp1.BaseDisplay
{
    internal class TvDisplay
    {
        public static Label createTv()      /*CREATES AND RETURNS TV ICON*/
        {
            var bulb = new Label
            {
                FontSize = 50,
                FontFamily = "MaterialDesignIcons",
                Text = MaterialDesignIconFonts.TelevisionClassic,
                HorizontalOptions = LayoutOptions.Center
            };

            return bulb;

        }

        public static Entry channel()
        {
            var channel = new Entry
            {
                Placeholder = "channel",
                Keyboard = Keyboard.Numeric,
                MaxLength = 3,


            };
            return channel;
        }
    }
}
