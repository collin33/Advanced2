using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
class SpriteRenderer: GameObject
{
    private Texture2D _texture;
    //private SpriteBatch _spriteBatch;
    public SpriteRenderer(Texture2D texture)
    {
        _texture = texture;
        //_spriteBatch = spriteBatch;
        //System.Diagnostics.Debug.Write("TESTETETETETETETETETETETETTETETETETTETE");
    }

    public override void Draw(Transform GameObject, SpriteBatch _spriteBatch, Texture2D textuuure)//Vector2 Position, float Rotation, Vector2 Anchorpoint, float Scale)
    {
        _spriteBatch.Begin();
        _spriteBatch.Draw(textuuure, GameObject.Position, null, Color.White, MathHelper.ToRadians(GameObject.Rotation), GameObject.AnchorPoint, GameObject.Scale, SpriteEffects.None, 0);
        _spriteBatch.End();
    }
}