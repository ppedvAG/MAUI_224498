namespace MauiKursApp.Navi;

[QueryProperty(nameof(Item1), "RouteItem1")]
public partial class RoutingTarget : ContentPage
{
	public string Item1 { set => Lbl_Output.Text = value; }

	public RoutingTarget()
	{
		InitializeComponent();
	}
}