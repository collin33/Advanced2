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