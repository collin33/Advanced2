using System;
namespace Advanced2
{
    class Bouncer : MonoBehaviour
    {
        private int StartPosition;
        private int BounceHeight;
        private float BounceSpeed;
        private int TimeInMilliseconds;
        private Transform _transform;

        public Bouncer(int Height, float Speed)
        {
            BounceHeight = Height;
            BounceSpeed = Speed;
        }

        public override void Awake(GameObject gameObject)
        {
            _transform = gameObject.Transform;
            StartPosition = (int)_transform.PositionY;
        }

        public override void Update(int Time)
        {
            TimeFormula(Time);
            if (TimeInMilliseconds > 10800)
            { TimeInMilliseconds -= 10800; }
            _transform.PositionY = StartPosition + (BounceHeight * MathF.Sin((float)TimeInMilliseconds / 30));
        }

        private void TimeFormula(int CurrentTime)
        {
            TimeInMilliseconds += (int)((CurrentTime / 2) * BounceSpeed);
        }
    }
}