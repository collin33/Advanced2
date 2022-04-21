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

        public void Update()
        {
            if (TimeInMilliseconds > 10800)
            { TimeInMilliseconds -= 10800; }
            _transform.Rotation += RotaterPower * TimeInMilliseconds;
        }

        public void Time(int CurrentTime)
        {
            TimeInMilliseconds = CurrentTime / 10;
        }
    }
}