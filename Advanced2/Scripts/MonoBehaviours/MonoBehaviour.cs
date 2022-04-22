namespace Advanced2
{
    public class MonoBehaviour : Component, IUpdateableComponent
    {
        public virtual void Update(int Time)
        {

        }

        //Only to be used when an object has a spriterenderer
        public virtual void OnCollision(GameObject gameObject)
        {
        }

    }
}