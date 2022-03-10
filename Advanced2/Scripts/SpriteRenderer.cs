using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
class SpriteRenderer: GameObject
{
    private Texture2D _texture;
    private SpriteBatch _spriteBatch;
    private Vector2 _position;
    private float _rotation;
    private Vector2 _anchorPoint;
    private Vector2 _scale;
    public SpriteRenderer(Texture2D texture, SpriteBatch spriteBatch, Vector2 position, float rotation, Vector2 anchorPoint, Vector2 scale)
    {
        _texture = texture;
        _spriteBatch = spriteBatch;
        _position = position;
        _rotation = rotation;
        _anchorPoint = anchorPoint;
        _scale = scale;

        //System.Diagnostics.Debug.Write("TESTETETETETETETETETETETETTETETETETTETE");
    }

    public override void ObjectUpdate()
    {
        System.Diagnostics.Debug.Write("RENDERER");
    }
    public void Draw()
    {
        _spriteBatch.Begin();
        _spriteBatch.Draw(_texture, //Texture2D texture
            _position, //Vector2 position
            null, //Rectangle sourceRectangle
            Color.White, //Color color
            MathHelper.ToRadians(_rotation), //float rotation
            _anchorPoint, //Vector2 origin
            _scale, //float scale
            SpriteEffects.None, //SpriteEffects effects
            0 //float layerDepth
            );
        _spriteBatch.End();
    }
}