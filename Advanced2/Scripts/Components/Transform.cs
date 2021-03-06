using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
class Transform
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
    #endregion
}