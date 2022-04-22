using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Advanced2
{
    class AnimatedSpriteRenderer : Component, IUpdateableComponent, IDrawableComponent
    {
        private Texture2D _texture;
        private Color _color = Color.White;
        private SpriteBatch _spriteBatch;
        private Transform _transform;
        private int TimeInMilliseconds;
        private Vector2 _spriteRectSize;
        private Vector2 _spriteRectPosition;
        private Vector2 _spriteSheetSize;
        private Vector2 _currentSprite;

        //Constructors
        public AnimatedSpriteRenderer(Texture2D texture, SpriteBatch spriteBatch, Vector2 sourceRectangleSize, Vector2 sheetDimensions)
        {
            _texture = texture;
            _spriteBatch = spriteBatch;
            _spriteRectSize = sourceRectangleSize;
            _spriteSheetSize = sheetDimensions;
        }

        public override void Awake(GameObject gameObject)
        {
            _transform = gameObject.Transform;
            //Debug.WriteLine(i);
        }

        public virtual void Update(int Time)
        {
            TimeFormula(Time);
            if (TimeInMilliseconds > 100)
            { TimeInMilliseconds -= 100; UpdateSprite(); }


            //(int)_spriteRectPosition.X, (int)_spriteRectPosition.Y, (int)_spriteRectSize.X, (int)_spriteRectSize.Y

        }

        public virtual void Draw()
        {
            _Draw(_transform, _spriteRectSize, _spriteRectPosition,  _spriteBatch, _texture);
        }


        private void _Draw(Transform transform,Vector2 _spriteRectPosition, Vector2 _sourceRectPosition, SpriteBatch _spriteBatch, Texture2D Texture)//Vector2 Position, float Rotation, Vector2 Anchorpoint, float Scale)
        {
            _spriteBatch.Draw(Texture, transform.Position, new Rectangle((int)_sourceRectPosition.X, (int)_sourceRectPosition.Y, (int)_spriteRectPosition.X, (int)_spriteRectPosition.Y), _color, MathHelper.ToRadians(transform.Rotation), new Vector2(transform.AnchorPoint.X * Texture.Width, transform.AnchorPoint.Y * Texture.Height), transform.Scale, SpriteEffects.None, (Single)transform.LayerDepth);
        }

        private void UpdateSprite()
        {
            if (_currentSprite.X < _spriteSheetSize.X-1)
            {
                _currentSprite.X += 1;
            }
            else
            {
                _currentSprite.X = 0;
                if (_currentSprite.Y < _spriteSheetSize.Y-1)
                {
                    _currentSprite.Y += 1;
                }
                else
                {
                    _currentSprite.Y = 0;
                }
                _spriteRectPosition.Y = _currentSprite.Y * _spriteRectSize.Y;
            }

            _spriteRectPosition.X = _currentSprite.X * _spriteRectSize.X;
        }

        private void TimeFormula(int CurrentTime)
        {
            TimeInMilliseconds += (int)((CurrentTime / 2));
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