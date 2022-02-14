using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
public class Transform : GameObject
{
    private Vector2 _position = new Vector2(0,0);
    private Vector2 _anchorPoint = new Vector2 (0,0);
    private float _rotation = 0;
    private Vector2 _scale = new Vector2 (1,1);

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

    public float Rotation
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