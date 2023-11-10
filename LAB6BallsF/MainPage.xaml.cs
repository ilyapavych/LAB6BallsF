using System.Timers;
using Timer = System.Timers.Timer;

namespace LAB6BallsF;

public partial class MainPage : ContentPage
{
	private double milliSecondsPerFrame = 30; // this is the number of ms
	public Timer timer; // this is the timer

	public MainPage()
	{
		InitializeComponent();
	}

	private void ContentPage_Loaded(Object sender, EventArgs e)
	{
		timer = new Timer();
		timer.Interval = milliSecondsPerFrame;
		timer.Elapsed += new ElapsedEventHandler(updateBallField);
		timer.Start();
	}

	private void updateBallField(object sender, ElapsedEventArgs e)
	{
            var graphicsView = this.BallGraphicsView;
            // maybe dontor need Drawable
            //var ballFieldDrawable = (BallField)graphicsView.Drawable;
            //ballFieldDrawable.
            graphicsView.Invalidate();
        }
}

