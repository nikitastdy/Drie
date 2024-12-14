using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Drie.Models;
using Microsoft.EntityFrameworkCore;
using static Drie.Classes.Utility;

namespace Drie.Views;

public partial class EditControl : UserControl
{
    private int id = -1;
    public EditControl(int _id)
    {
        InitializeComponent();
        id = _id;
        if (id == -1)
        {
            DriveSp.DataContext = new Driver();
        }
        else
        {
            DriveSp.IsEnabled = false;
            var driver = database.Drivers.Find(id);
            DriveSp.DataContext = driver;
        }
    }

    private void ConfirmB_OnClick(object? sender, RoutedEventArgs e)
    {
        if (id == -1)
        {
            var driver = DriveSp.DataContext as Driver;
            database.Drivers.Add(driver);
        }
        else
        {
            var driver = database.Drivers.Find(id);
            database.Drivers.Update(driver);
        }
        database.SaveChanges();
        UtiContentControl.Content = new DataControl();
    }
}