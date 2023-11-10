namespace LAB6BallsF;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
	void ContentPage_Loaded(System.Object sender, System.EventArgs e)
	{
		drawBall();
	}
	private void drawBall()
	{
		var graphicsView = this.BallGraphicsView;
        // maybe dontor need Drawable
        //var ballFieldDrawable = (BallField)graphicsView.Drawable;
		//ballFieldDrawable.

    }
}


