namespace MauiKursApp.Navi;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("navi/routeTarget", typeof(Navi.RoutingTarget));
	}
}