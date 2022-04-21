namespace Advanced2
{
    public class Rotator : MonoBehaviour
    {
        private int RotaterPower;
        private int TimeInMilliseconds;
        private Transform _transform;

        public Rotator(int RotationSpeed)
        {
            RotaterPower = RotationSpeed;
        }

        public override void Awake(GameObject gameObject)
        {
            _transform = gameObject.Transform;
        }

        public override void Update(int Time)
        {
            if (TimeInMilliseconds > 10800)
            { TimeInMilliseconds -= 10800; }
            TimeDecreaser(Time);
            _transform.Rotation += RotaterPower * TimeInMilliseconds;
        }

        private void TimeDecreaser(int CurrentTime)
        {
            TimeInMilliseconds = CurrentTime / 10;
        }
    }
}