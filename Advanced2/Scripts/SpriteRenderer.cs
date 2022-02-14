using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
public class SpriteRenderer : GameObject
{
    public void Draw(Texture2D texture, SpriteBatch spriteBatch, Vector2 position)
    {
        spriteBatch.Begin();
        //spriteBatch.Draw(texture, new Vector2(0x0), Color.White);
        //spriteBatch.Draw(Texture2D texture, Vector2 position, Rectangle ? sourceRectangle, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth)
        spriteBatch.Draw(texture, position, null, Color.White, 0, new Vector2(0, 0), new Vector2(1, 1), SpriteEffects.None, 0);
        spriteBatch.End();
        //_spriteBatch.Draw(_texture, new Vector2(0x0), Color.White);
        //Draw(Texture2D, Vector2, Nullable<Rectangle>, Color, Single, Vector2, Single, SpriteEffects, Single)
    }
}