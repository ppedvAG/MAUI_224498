namespace MauiKursApp.Navi;

public partial class NavPageBsp : ContentPage
{
	public NavPageBsp()
	{
		InitializeComponent();
	}

    private void Btn_Grundlagen_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Xaml_Grundlagen());
    }

    private void Btn_Controls_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Controls());
    }
}