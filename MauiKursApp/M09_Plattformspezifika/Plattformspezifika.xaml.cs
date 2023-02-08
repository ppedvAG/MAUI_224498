namespace MauiKursApp.Plattformspezifika;

public partial class Plattformspezifika : ContentPage
{
	public Plattformspezifika()
	{
		InitializeComponent();

		DeviceOrientationService service = new DeviceOrientationService();

		Lbl_Orientation.Text = service.GetOrientation().ToString();
	}
}