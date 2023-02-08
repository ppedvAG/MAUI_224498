namespace MauiKursApp.Navi;

[QueryProperty(nameof(Item1), "RouteItem1")]
[QueryProperty(nameof(Item2), "RouteItem2")]
public partial class RoutingTarget : ContentPage
{
    public string Item1 { set => Lbl_Show.Text = value; }

    public string Item2 { get; set; }

	public RoutingTarget()
	{
		InitializeComponent();
	}
}