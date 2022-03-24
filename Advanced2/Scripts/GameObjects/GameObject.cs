using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
class GameObject
{
    //Components
    public Transform _Transform = new Transform(new Vector2(0, 0), new Vector2((float)0.5, (float)0.5), 0, new Vector2(1, 1));
    public SpriteRenderer _SpriteRenderer = new SpriteRenderer(null);

    public virtual void ObjectUpdate()
    {
        //System.Diagnostics.Debug.Write("GameObjectUpdate"); 
    }
}