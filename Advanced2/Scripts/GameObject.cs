using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
public class GameObject
{
    //naam van het gameobject
    string name;
    SpriteRenderer _spriteRenderer;
    Transform _transform;

    public void OnCreated()
    {
        _spriteRenderer = new SpriteRenderer();
        _transform = new Transform();
    }

    public virtual void ObjectUpdate()
    {
    }

    public void Position(Vector2 position)
    {
        _transform.Position = position;
    }

    public void Rotation (float rotation)
    {
        _transform.Rotation = rotation;
    }
    
    //Info doorgeven aan sprite renderer. Voeg hier transform info aan toe.
    public virtual void _SpriteRenderer(Texture2D texture, SpriteBatch spriteBatch)
    {
        _spriteRenderer.Draw(texture, spriteBatch, _transform.Rotation, _transform.Position);
        //SpriteRenderer.Draw()
    }
}