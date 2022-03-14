using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

class BounceObject : GameObject
{
    //Components
    public Transform _Transform = new Transform(new Vector2(288, 288), new Vector2((float)0.5, (float)0.5), 0, new Vector2(2, 2));
    public SpriteRenderer _SpriteRenderer = new SpriteRenderer(null);

    private int StartPosition = 96*2;
    private int BounceHeight;
    private int BounceSpeed;
    private int TimeInMilliseconds;

    public BounceObject(int Height, int Speed)
    {
        BounceHeight = Height;
        BounceSpeed = Speed;
    }

    public override void ObjectUpdate()
    {
        if (TimeInMilliseconds > 180)
        {
            TimeInMilliseconds -= 180;
        }
        _Transform._position.Y = StartPosition - (BounceHeight * MathF.Sin(TimeInMilliseconds));
    }

    public void Time(int CurrentTime)
    {
        TimeInMilliseconds += CurrentTime/10;
    }
}