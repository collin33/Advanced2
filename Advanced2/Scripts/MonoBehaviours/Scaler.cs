using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
namespace Advanced2
{
    class Scaler : MonoBehaviour
    {
        private float ScaleSpeed;
        private int TimeInMilliseconds;
        private float MinimumScale;
        private Vector2 OriginalScale;
        private Vector2 ScaleDiff;
        private Transform _transform;

        public Scaler(float MinScale, float Speed)
        {
            MinimumScale = MinScale > 0.01 ? MinScale : (float)0.01;
            ScaleSpeed = Speed;
        }

        public override void Awake(GameObject gameObject)
        {
            _transform = gameObject.Transform;

            //Store the original scale so we can use it in calculations
            OriginalScale = _transform.Scale;

            // Difference between the original scale and the minimum calculated scale
            ScaleDiff = new Vector2(OriginalScale.X - (OriginalScale.X * MinimumScale), OriginalScale.Y - (OriginalScale.Y * MinimumScale));
        }

        public override void Update(int Time)
        {
            TimeFormula(Time);

            if (TimeInMilliseconds > 10800)
            {
                TimeInMilliseconds -= 10800;
            }

            _transform.ScaleX = ScaleDiff.X * Math.Abs(MathF.Sin((float)TimeInMilliseconds / 30)) + MinimumScale * OriginalScale.X;
            _transform.ScaleY = ScaleDiff.Y * Math.Abs(MathF.Sin((float)TimeInMilliseconds / 30)) + MinimumScale * OriginalScale.Y;
            //System.Diagnostics.Debug.WriteLine(" || OriginalScaleY: " + OriginalScale.Y + " - MinimumScale: " + MinimumScale + " - Calc: " + (float)(OriginalScale.Y - (OriginalScale.Y * MinimumScale)) + " - ScaleDiff " + ScaleDiff);
        }

        private void TimeFormula(int CurrentTime)
        {
            TimeInMilliseconds += (int)((CurrentTime / 2) * ScaleSpeed);
        }
    }
}