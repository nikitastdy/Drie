using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Drie.Models;
using Microsoft.EntityFrameworkCore;
using static Drie.Classes.Utility;

namespace Drie.Views;

public partial class DataControl : UserControl
{
    private bool showacrhive = false;
    public DataControl()
    {
        InitializeComponent();
        LoadData();
    }

    public void LoadData()
    {
        database.Drivers.Load();
        DriveDg.ItemsSource = database.Drivers.Where(el => el.Archive == 0).ToList();
    }

    private void DeleteB_OnClick(object? sender, RoutedEventArgs e)
    {
        var driver = DriveDg.SelectedItem as Driver;
        if (driver != null)
        {
            driver.Archive = 1;
            database.SaveChanges();
            LoadData();
        }
    }

    private void ArchiveB_OnClick(object? sender, RoutedEventArgs e)
    {
        if (showacrhive == false)
        {
            DriveDg.ItemsSource = database.Drivers.Where(el => el.Archive == 1).ToList();
            ArchiveB.Content = "show non-archive";
            showacrhive = true;
        }
        else
        {
            LoadData();
            ArchiveB.Content = "show archive";
            showacrhive = false;
        }
        
    }

    private void EditB_OnClick(object? sender, RoutedEventArgs e)
    {
        if (DriveDg.SelectedItem != null)
        {
            UtiContentControl.Content = new EditControl((DriveDg.SelectedItem as Driver).Id);
        }
    }

    private void AddB_OnClick(object? sender, RoutedEventArgs e)
    {
        UtiContentControl.Content = new EditControl(-1);
    }
}