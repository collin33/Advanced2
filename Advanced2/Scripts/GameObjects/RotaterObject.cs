﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
class RotaterObject : GameObject
{
    //Components
    public Transform _Transform = new Transform(new Vector2(96, 96), new Vector2((float)0.5, (float)0.5), 0, new Vector2(2, 2));
    public SpriteRenderer _SpriteRenderer = new SpriteRenderer(null);
    private int RotaterPower;

    public RotaterObject(int RotationSpeed){
        RotaterPower = RotationSpeed;
    }

    public override void ObjectUpdate()
    {
        _Transform.Rotation += RotaterPower;
    }
}