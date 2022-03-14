using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
class TestObject : GameObject
{
    //Components
    public Transform _Transform = new Transform(new Vector2(96, 96), new Vector2((float)0.5, (float)0.5), 0, new Vector2(2, 2));
    public SpriteRenderer _SpriteRenderer = new SpriteRenderer(null);

    public override void ObjectUpdate()
    {
        //System.Diagnostics.Debug.Write("TestObjectUpdate"); 
    }
}