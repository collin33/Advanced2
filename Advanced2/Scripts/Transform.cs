using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
class Transform : GameObject
{
    private Vector2 _position = new Vector2(10, 10);
    private Vector2 _anchorPoint = new Vector2(0, 0);
    private int _rotation = 0;
    private Vector2 _scale = new Vector2(1, 1);

    public Transform(Vector2 Position, Vector2 AnchorPoint, int Rotation, Vector2 Scale)
    {
        _position = Position;
        _anchorPoint = AnchorPoint;
        _rotation = Rotation;
        _scale = Scale;
    }

    public Vector2 Position
    {
        get { return _position; }
        set
        {
            _position = value;
        }
    }

    public Vector2 AnchorPoint
    {
        get { return _anchorPoint; }
        set
        {
            _anchorPoint = value;
        }
    }

    public int Rotation
    {
        get { return _rotation; }
        set
        {
            _rotation = value;
        }
    }

    public Vector2 Scale
    {
        get { return _scale; }
        set
        {
            _scale = value;
        }
    }
}