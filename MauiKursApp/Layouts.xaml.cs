namespace MauiKursApp;

public partial class Layouts : ContentPage
{
	public Layouts()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Grid.SetColumn(Btn_Move, 1);
    }
}