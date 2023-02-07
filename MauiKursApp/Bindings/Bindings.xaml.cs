namespace MauiKursApp.Bindings;

public partial class Bindings : ContentPage
{
	public Bindings()
	{
		InitializeComponent();
	}

    private async void Btn_Show_Clicked(object sender, EventArgs e)
    {
		Person person = (Stl_DataBinding.BindingContext as Person);

		await DisplayAlert("Person:", $"{person.Name} ({person.Alter})", "ok");
    }

    private void Btn_Altern_Clicked(object sender, EventArgs e)
    {
        (Stl_DataBinding.BindingContext as Person).Alter++;
    }

    private void Btn_Add_Clicked(object sender, EventArgs e)
    {
        (Stl_DataBinding.BindingContext as Person).WichtigeTage.Add(new DateTime(2000, 1, 1));
    }

    private void Btn_Delete_Clicked(object sender, EventArgs e)
    {
        if (LstV_Tage.SelectedItem != null)
            (Stl_DataBinding.BindingContext as Person).WichtigeTage.Remove((DateTime)LstV_Tage.SelectedItem);
    }
}