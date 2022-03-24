using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

class BounceObject : GameObject
{
    private int StartPosition = 96*2;
    private int BounceHeight;
    private float BounceSpeed;
    private int TimeInMilliseconds;

    public BounceObject(int Height, float Speed)
    {
        BounceHeight = Height;
        BounceSpeed = Speed;
    }

    public override void ObjectUpdate()
    {
        if (TimeInMilliseconds > 10800)
        { TimeInMilliseconds -= 10800; }
        _Transform.PositionY = StartPosition - (BounceHeight * MathF.Sin((float)TimeInMilliseconds/30));
    }

    public void Time(int CurrentTime)
    {
        TimeInMilliseconds += (int)((CurrentTime / 2) * BounceSpeed);
    }
}