using System;
namespace LAB6BallsF;

public class BallField : IDrawable 
{
    public int position = 0;

    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        // Drawing code goes here
        canvas.StrokeColor = Colors.Red;
        canvas.StrokeSize = 4;
        canvas.DrawEllipse(10 + position++, 10 + position++, 100, 100);
        //
        canvas.FillColor = Colors.Red;
        canvas.FillEllipse(200 + position++, 200 + position++, 150, 50);
    }
}

