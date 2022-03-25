using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
class SpriteRenderer
{
    private Texture2D _texture;
    //private SpriteBatch _spriteBatch;
    public SpriteRenderer(Texture2D texture)
    {
        _texture = texture;
    }

    public void Draw(Transform GameObject, SpriteBatch _spriteBatch, Texture2D Texture)//Vector2 Position, float Rotation, Vector2 Anchorpoint, float Scale)
    {
        _spriteBatch.Begin();
        _spriteBatch.Draw(Texture, GameObject.Position, null, Color.White, MathHelper.ToRadians(GameObject.Rotation), new Vector2 (GameObject.AnchorPoint.X * Texture.Width, GameObject.AnchorPoint.Y * Texture.Height) , GameObject.Scale, SpriteEffects.None, GameObject.LayerDepth);
        _spriteBatch.End();
    }
}