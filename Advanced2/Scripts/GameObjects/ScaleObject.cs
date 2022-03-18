using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

class ScaleObject : GameObject
{
    //Components
    public Transform _Transform = new Transform(new Vector2(96*5, 96), new Vector2((float)0.5, (float)0.5), 0, new Vector2(2, 2));
    public SpriteRenderer _SpriteRenderer = new SpriteRenderer(null);

    private float ScaleSpeed;
    private int TimeInMilliseconds;
    private float MinimumScale;
    private Vector2 OriginalScale;
    private Vector2 ScaleDiff;

    public ScaleObject(float MinScale, float Speed)
    {
        MinimumScale = MinScale > 0.01 ? MinScale : (float)0.01;
        ScaleSpeed = Speed;
        OriginalScale = _Transform.Scale;

        // Difference between the original scale and the minimum calculated scale
        ScaleDiff = new Vector2(OriginalScale.X - (OriginalScale.X * MinimumScale), OriginalScale.Y - (OriginalScale.Y * MinimumScale));
    }

    public override void ObjectUpdate()
    {
        if (TimeInMilliseconds > 10800)
        {
            TimeInMilliseconds -= 10800;
        }

        _Transform.ScaleX = ScaleDiff.X * Math.Abs(MathF.Sin((float)TimeInMilliseconds / 30)) + MinimumScale * OriginalScale.X;
        _Transform.ScaleY = ScaleDiff.Y * Math.Abs(MathF.Sin((float)TimeInMilliseconds / 30)) + MinimumScale * OriginalScale.Y;
        System.Diagnostics.Debug.Write(" || OriginalScaleY: "+ OriginalScale.Y + " - MinimumScale: " + MinimumScale + " - Calc: "+ (float)(OriginalScale.Y - (OriginalScale.Y * MinimumScale)) + " - ScaleDiff " + ScaleDiff
            );
    }

    public void Time(int CurrentTime)
    {
        TimeInMilliseconds += (int)((CurrentTime/2) * ScaleSpeed);
    }
}