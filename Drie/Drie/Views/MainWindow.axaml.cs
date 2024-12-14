using System;
using System.Net;
using System.Net.Mail;
using Avalonia.Controls;
using Avalonia.Interactivity;
using static Drie.Classes.Utility;

namespace Drie.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        UtiContentControl = MainContentControl;
        UtiContentControl.Content = new MainView();
    }
}