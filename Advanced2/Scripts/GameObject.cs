using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
abstract class GameObject
{
    public virtual void ObjectUpdate()
    {
        System.Diagnostics.Debug.Write("#"); 
    }

    public virtual void Draw(Transform GameObject, SpriteBatch _spriteBatch, Texture2D textuuure)//Vector2 Position, float Rotation, Vector2 Anchorpoint, float Scale)
    {
        _spriteBatch.Draw(textuuure, new Vector2(0x0), Color.White);
    }
}