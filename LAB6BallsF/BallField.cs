using LAB6BallsF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
namespace LAB6BallsF;

public class BallField : IDrawable 
{
    public Ball[] Balls; // this is the array of balls
    public int ballCount { get; set; } = 100;
    public int ballSpeed { get; set; } = 100;
    public double width { get; set; } = 1000;
    public double height { get; set; } = 1000;

    //Ball ball = new Ball(100, 100, 20, 10, 11, 128, 128, 128);

    public BallField() // this is a constructor 
    {
        newBalls(ballCount); // this is a method that create the balls
        //Ball ball = new Ball(100, 100, 20, 10, 11, 128, 128, 128);
    }

    private void newBalls(int ballCount)
    {
        Balls = new Ball[ballCount]; // this creates the array of balls
        Random rand = new(); // this is a random number generator
        for (int i = 0; i < Balls.Length; i++) // this is a loop that creates the balls
        {
            double X = rand.NextDouble() * width;
            double Y = rand.NextDouble() * height;
            double RADIUS = rand.NextDouble() * 5 + 5; // this is a random number between 5 and 10
            double XVel = rand.NextDouble() - .5;
            double YVel = rand.NextDouble() - .5;
            byte R = (byte)(rand.Next(50, 255));
            byte G = (byte)(rand.Next(50, 255));
            byte B = (byte)(rand.Next(50, 255));
            Balls[i] = new Ball
                (
                    x: X,
                    y: Y,
                    radius: RADIUS,
                    xVel: XVel,
                    yVel: YVel,
                    r: R,
                    g: G,
                    b: B
                );
        }
        
    }

    public void Draw(ICanvas canvas, RectF dirtyRect) // this is a method that draws the ball
    {
        // Drawing code goes here
        foreach(Ball ball in Balls)
        {
        ball.Advance(ballSpeed, width, height);
        ball.Draw(canvas);
        }
        
    }
}

