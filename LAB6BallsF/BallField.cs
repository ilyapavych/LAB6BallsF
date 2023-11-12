using System;
namespace LAB6BallsF;

public class BallField : IDrawable 
{
    Ball ball = new Ball(100, 100, 20, 10, 11, 128, 128, 128);

    public BallField()
    {
        Ball ball = new Ball(100, 100, 20, 10, 11, 128, 128, 128);
    }


    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        // Drawing code goes here
        canvas.StrokeColor = Colors.Red;
        canvas.StrokeSize = 4;
        canvas.DrawEllipse(10, 10, 100, 100);
        //
        canvas.FillColor = Colors.Red;
        canvas.FillEllipse(200, 200, 150, 50);
        //
        ball.Advance(2, 1000, 1000);
        ball.Draw(canvas);
    }
}

