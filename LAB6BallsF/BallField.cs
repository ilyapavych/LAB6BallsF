using System;
namespace LAB6BallsF;

public class BallField : IDrawable 
{
    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        canvas.StrokeColor = Colors.Red;
        canvas.StrokeSize = 4;
        canvas.DrawEllipse(10, 10, 100, 100);
        // Drawing code goes here
    }
}

