using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
class Transform : GameObject
{
    private Vector2 _position = new Vector2(0, 0);
    private Vector2 _anchorPoint = new Vector2(0, 0);
    private float _rotation = 0;
    private Vector2 _scale = new Vector2(1, 1);

    public Transform(Vector2 Position, Vector2 AnchorPoint, float Rotation, Vector2 Scale)
        {
        _position = Position;
        _anchorPoint = AnchorPoint;
        _rotation = Rotation;
        _scale = Scale;
        }
}