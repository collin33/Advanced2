using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Advanced2
{
    class SpriteRenderer : MonoBehaviour
    {
        private Texture2D _texture;
        private Color _color = Color.White;
        private SpriteBatch _spriteBatch;
        private Transform _transform;
        //Constructors
        public SpriteRenderer(Texture2D texture, SpriteBatch spriteBatch)
        {
            _texture = texture;
            _spriteBatch = spriteBatch;
        }

        public override void Awake(GameObject gameObject)
        {
            _transform = gameObject.Transform;
            //Debug.WriteLine(i);
        }


        public override void Draw()
        {
            _Draw(_transform, _spriteBatch, _texture);
        }


        private void _Draw(Transform transform, SpriteBatch _spriteBatch, Texture2D Texture)//Vector2 Position, float Rotation, Vector2 Anchorpoint, float Scale)
        {
            _spriteBatch.Draw(Texture, transform.Position, null, _color, MathHelper.ToRadians(transform.Rotation), new Vector2(transform.AnchorPoint.X * Texture.Width, transform.AnchorPoint.Y * Texture.Height), transform.Scale, SpriteEffects.None, (Single)transform.LayerDepth);
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