using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AuroraAvalonia;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        this.FindControl<ContentControl>("ThemeContentControl").Content = new Aurora();
    }
}
