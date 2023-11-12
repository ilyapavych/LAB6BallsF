using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Graphics;

namespace LAB6BallsF;

public class Ball
{
    // this is the x, y coordinate of the ball
    public double X;
    public double Y;
    public double Radius = 5; // this is radius of the ball
    // this is x and y velocity of the vall
    public double XVel; 
    public double YVel;
    public byte R, G, B; // that is colour of the ball

    public Ball(double x, double y, double radius, double xVel, double yVel, byte r, byte g, byte b)
    {
        X = x;
        Y = y;
        Radius = radius;
        XVel = xVel;
        YVel = yVel;
        R = r;
        G = g;
        B = b;
    }
    public void Advance(double ballSpeed, double width, double height)
    {
        MoveBall(ballSpeed);
        Bounce(width, height);
    }

    private void MoveBall(double ballSpeed)
    {
        // moves the ball forward in the x and y direction
        X += XVel * ballSpeed;
        Y += YVel * ballSpeed;
    }

    private void Bounce(double width, double height)
    {
        double minX = Radius; // this is the min x value of the ball
        double minY = Radius; // this is the min y value of the ball
        double maxX = width - Radius; // this is the max x value of the ball
        double maxY = height - Radius; // this is the max y value of the ball

        if(X < minX)
        {
            double over = minX - X; // this is the difference between the min x and x size of ball
            X = minX + over; // this sets the x value of the ball to the min x
            XVel = -XVel; // this reverses the x velocity of the ball
        }

        else if(X > maxX) // this check if the ball is greater than the max x
        {
            double over = X - maxX; // this is the difference between the max x and x size of ball
            X = maxX - over; // this sets the x value of the ball to the max x
            XVel = -XVel; // this reverses the x velocity of the ball
        }

        if(Y < minY) // this checks if the ball is less than the min y value
        {
            double over = minY - Y;
            Y = minY + over;
            YVel = -YVel;
        }

        else if(Y > maxY)
        {
            double over = Y - maxY;
            Y = maxY - over;
            YVel = -YVel;
        }
    }
    public void Draw(ICanvas canvas)
    {
        canvas.FillColor = Color.FromRgb(R, G, B);
        canvas.FillCircle((float)X, (float)Y, (float)Radius);
    }
}


