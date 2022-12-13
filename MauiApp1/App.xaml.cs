//using Microsoft.Maui.Controls;
//using Syncfusion.Maui.ListView;
//using System;



using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Application = Microsoft.Maui.Controls.Application;



namespace MauiApp1;

public partial class App : Application
{

    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
          /*  DeviceRepository viewModel = new DeviceRepository();
            listView = new SfListView();
            listView.ItemSize = 100;
            listView.ItemsSource = viewModel.DeviceInfo;
            listView.ItemTemplate = new DataTemplate(() => {
                var grid = new Grid();
                grid.RowDefinitions.Add(new RowDefinition());
                grid.RowDefinitions.Add(new RowDefinition());
                var deviceName = new Label { FontAttributes = FontAttributes.Bold, BackgroundColor = Colors.Teal, FontSize = 21 };
                deviceName.SetBinding(Label.TextProperty, new Binding("DeviceName"));
                var deviceStatus = new Label { BackgroundColor = Colors.Teal, FontSize = 15 };
                deviceStatus.SetBinding(Label.TextProperty, new Binding("DeviceStatus"));

                grid.Children.Add(deviceName);
                grid.Children.Add(deviceStatus);
                grid.SetRow(deviceName, 0);
                grid.SetRow(deviceStatus, 1);

                return grid;
            });
        MainPage = new ContentPage { Content = listView };*/
    }

    


    /*protected override Window CreateWindow(IActivationState activationState)
    {
        Window window = base.CreateWindow(activationState);

        // Manipulate Window object

        return window;
    }*/

/*
    SfListView listView;
    public App()
    {
        DeviceRepository viewModel = new DeviceRepository();
        listView = new SfListView();
        listView.ItemSize = 100;
        listView.ItemsSource = viewModel.DeviceInfo;
        listView.ItemTemplate = new DataTemplate(() => {
            var grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            var deviceName = new Label { FontAttributes = FontAttributes.Bold, BackgroundColor = Colors.Teal, FontSize = 21 };
            deviceName.SetBinding(Label.TextProperty, new Binding("DeviceName"));
            var deviceStatus = new Label { BackgroundColor = Colors.Teal, FontSize = 15 };
            deviceStatus.SetBinding(Label.TextProperty, new Binding("DeviceStatus"));

            grid.Children.Add(deviceName);
            grid.Children.Add(deviceStatus);
            grid.SetRow(deviceName, 0);
            grid.SetRow(deviceStatus, 1);

            return grid;
        });
        MainPage = new ContentPage { Content = listView };
    }*/
}
//}
