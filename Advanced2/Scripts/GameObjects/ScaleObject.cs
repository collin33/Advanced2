//using Microsoft.Xna.Framework;
//using Microsoft.Xna.Framework.Graphics;
//using System;

//class ScaleObject : GameObject
//{
//    private float ScaleSpeed;
//    private int TimeInMilliseconds;
//    private float MinimumScale;
//    private Vector2 OriginalScale;
//    private Vector2 ScaleDiff;

//    public ScaleObject(float MinScale, float Speed)
//    {
//        MinimumScale = MinScale > 0.01 ? MinScale : (float)0.01;
//        ScaleSpeed = Speed;
//        OriginalScale = _Transform.Scale;

//        // Difference between the original scale and the minimum calculated scale
//        ScaleDiff = new Vector2(OriginalScale.X - (OriginalScale.X * MinimumScale), OriginalScale.Y - (OriginalScale.Y * MinimumScale));
//    }

//    public override void ObjectUpdate()
//    {
//        if (TimeInMilliseconds > 10800)
//        {
//            TimeInMilliseconds -= 10800;
//        }

//        _Transform.ScaleX = ScaleDiff.X * Math.Abs(MathF.Sin((float)TimeInMilliseconds / 30)) + MinimumScale * OriginalScale.X;
//        _Transform.ScaleY = ScaleDiff.Y * Math.Abs(MathF.Sin((float)TimeInMilliseconds / 30)) + MinimumScale * OriginalScale.Y;
//        System.Diagnostics.Debug.Write(" || OriginalScaleY: "+ OriginalScale.Y + " - MinimumScale: " + MinimumScale + " - Calc: "+ (float)(OriginalScale.Y - (OriginalScale.Y * MinimumScale)) + " - ScaleDiff " + ScaleDiff
//            );
//    }

//    public void Time(int CurrentTime)
//    {
//        TimeInMilliseconds += (int)((CurrentTime/2) * ScaleSpeed);
//    }
//}