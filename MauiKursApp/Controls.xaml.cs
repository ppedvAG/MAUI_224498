namespace MauiKursApp;

public partial class Controls : ContentPage
{
	public Controls()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		Lbl_Output.Text = Ent_Input.Text;
    }

    private void Ent_Input_Completed(object sender, EventArgs e)
    {

    }

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        Lbl_Output.Text = (sender as Slider).Value.ToString();
    }
}