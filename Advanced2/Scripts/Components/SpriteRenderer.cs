using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
class SpriteRenderer : MonoBehaviour
{
    private Texture2D _texture;
    //private SpriteBatch _spriteBatch;
    public SpriteRenderer(Texture2D texture)
    {
        _texture = texture;
    }

    public void Draw(Transform GameObject, SpriteBatch _spriteBatch, Texture2D Texture)//Vector2 Position, float Rotation, Vector2 Anchorpoint, float Scale)
    {
        _spriteBatch.Draw(Texture, GameObject.Position, null, Color.White, MathHelper.ToRadians(GameObject.Rotation), new Vector2 (GameObject.AnchorPoint.X * Texture.Width, GameObject.AnchorPoint.Y * Texture.Height) , GameObject.Scale, SpriteEffects.None, (Single)GameObject.LayerDepth);
    }

    public Texture2D Texture
    {
        get { return _texture; }
        set { _texture = value; }
    }
}