using Avalonia.Controls;
using Avalonia.Interactivity;
using static Drie.Classes.Utility;

namespace Drie.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
        
    }
    
    private void LoginB_OnClick(object? sender, RoutedEventArgs e)
    {
        if (LoginTb.Text == "inspector" && PasswordTb.Text == "inspector")
        {
            UtiContentControl.Content = new DataControl();
        }
        UtiContentControl.Content = new DataControl();
    }
}