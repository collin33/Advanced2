using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
namespace Advanced2
{
    class SpriteRenderer : MonoBehaviour
    {
        private Texture2D _texture;
        private Color _color = Color.White;
        private GameObject _gameObject;
        private SpriteBatch _spriteBatch;

        //Constructors
        public SpriteRenderer(Texture2D texture, SpriteBatch spriteBatch)
        {
            _texture = texture;
            _spriteBatch = spriteBatch;
        }

        public override void Awake(GameObject gameObject)
        {
            _gameObject = gameObject;
        }


        public override void Draw()
        {
            _Draw(_gameObject.Transform, _spriteBatch, _texture);
        }


        private void _Draw(Transform GameObject, SpriteBatch _spriteBatch, Texture2D Texture)//Vector2 Position, float Rotation, Vector2 Anchorpoint, float Scale)
        {
            _spriteBatch.Draw(Texture, GameObject.Position, null, _color, MathHelper.ToRadians(GameObject.Rotation), new Vector2(GameObject.AnchorPoint.X * Texture.Width, GameObject.AnchorPoint.Y * Texture.Height), GameObject.Scale, SpriteEffects.None, (Single)GameObject.LayerDepth);
            Console.WriteLine("RENDER");
        }

        //Texture is already set in the constructor, however, we might want to change the sprite during runtime
        public Texture2D Texture
        {
            get { return _texture; }
            set { _texture = value; }
        }

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public SpriteBatch SpriteBatch
        {
            get { return SpriteBatch; }
            set { SpriteBatch = value; }
        }
    }
}