using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
public class SpriteRenderer : GameObject
{
    public void Draw(Texture2D texture, SpriteBatch spriteBatch, Vector2 position, float rotation, Vector2 anchorPoint, Vector2 scale)
    {
        spriteBatch.Begin();
        spriteBatch.Draw(texture, //Texture2D texture
            position, //Vector2 position
            null, //Rectangle sourceRectangle
            Color.White, //Color color
            MathHelper.ToRadians(rotation), //float rotation
            anchorPoint, //Vector2 origin
            scale, //float scale
            SpriteEffects.None, //SpriteEffects effects
            0 //float layerDepth
            );
        spriteBatch.End();
    }
}