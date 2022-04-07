//using Microsoft.Xna.Framework;
//using Microsoft.Xna.Framework.Graphics;
//class RotaterObject : GameObject
//{
//    private int RotaterPower;
//    private int TimeInMilliseconds;

//    public RotaterObject(int RotationSpeed){
//        RotaterPower = RotationSpeed;
//    }

//    public override void ObjectUpdate()
//    {
//        if (TimeInMilliseconds > 10800)
//        { TimeInMilliseconds -= 10800; }
//        _Transform.Rotation += RotaterPower * TimeInMilliseconds;
//    }

//    public void Time(int CurrentTime)
//    {
//        TimeInMilliseconds = CurrentTime/10;
//    }
//}