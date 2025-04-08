namespace Homemade_Budget_Tracker.MauiHybrid;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new MainPage()) { Title = "Homemade_Budget_Tracker" };
    }
}
