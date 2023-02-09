namespace MauiKursApp;

public partial class Gestures : ContentPage
{
	public Gestures()
	{
		InitializeComponent();
	}

    private void DragGestureRecognizer_DragStarting(object sender, DragStartingEventArgs e)
    {
        e.Data.Text = Lbl_Drag.Text;
    }

    private void DropGestureRecognizer_Drop(object sender, DropEventArgs e)
    {
        Lbl_Drop.Text = e.Data.GetTextAsync().Result;
    }

    private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
    {
        Lbl_Drag.Text = "SWIPED";
    }
}