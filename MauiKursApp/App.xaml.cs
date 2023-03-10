using System.Diagnostics;

namespace MauiKursApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //MainPage beinhaltet die jeweils angezeigte Seite. Zuweisungen hier definieren die Startpage der App.
        //MainPage = new Bindings.Bindings();

        //MainPage = new NavigationPage(new Navi.NavPageBsp());

        //MainPage = new Navi.TabbedPageBsp();

        //MainPage = new Navi.FlyoutBsp.FlyoutPage1();

        MainPage = new Navi.AppShell();
	}


    //Override der CreateWindow() um Zugriff auf globale shared Lifecycle-Events zu haben (für OS-spezifische LC-Events siehe MauiProgram.cs)
    protected override Window CreateWindow(IActivationState activationState)
    {
        Window window = base.CreateWindow(activationState);

        window.Created += (s, e) => Debug.Print("SharedCreated");
        window.Stopped += (s, e) => Debug.Print("SharedStopped");

        return window;
    }
}
