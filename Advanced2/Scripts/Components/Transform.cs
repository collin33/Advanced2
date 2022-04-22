using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
namespace Advanced2
{
    public class Transform : Component
    {
        private Vector2 _position = new Vector2(0, 0);
        private Vector2 _anchorPoint = new Vector2((float)0.5, (float)0.5);
        private int _rotation = 0;
        private Vector2 _scale = new Vector2(1, 1);
        private Single _layerdepth = 0;

        public Transform(Vector2 Position, Vector2 AnchorPoint, int Rotation, Vector2 Scale)
        {
            _position = Position;
            _anchorPoint = AnchorPoint;
            _rotation = Rotation;
            _scale = Scale;
        }

        public void ResetTransform()
        {
            _position = new Vector2(0, 0);
            _anchorPoint = new Vector2((float)0.5, (float)0.5);
            _rotation = 0;
            _scale = new Vector2(1, 1);
            _layerdepth = 0;
        }

        #region Get and set values
        public Vector2 Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public float PositionX
        {
            get { return _position.X; }
            set { _position.X = value; }
        }

        public float PositionY
        {
            get { return _position.Y; }
            set { _position.Y = value; }
        }

        public Vector2 AnchorPoint
        {
            get { return _anchorPoint; }
            set { _anchorPoint = value; }
        }

        public int Rotation
        {
            get { return _rotation; }
            set { _rotation = value; }
        }

        public Vector2 Scale
        {
            get { return _scale; }
            set { _scale = value; }
        }

        public float ScaleX
        {
            get { return _scale.X; }
            set { _scale.X = value; }
        }

        public float ScaleY
        {
            get { return _scale.Y; }
            set { _scale.Y = value; }
        }

        public Single LayerDepth
        {
            get { return _layerdepth; }
            set { _layerdepth = value; }
        }
        #endregion
    }
}