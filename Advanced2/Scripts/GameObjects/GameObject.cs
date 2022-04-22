using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Advanced2
{
    public class GameObject
    {
        //Fields
        private string _name;

        private Transform _transform;

        private List<Component> _components = new List<Component>();
        private List<IDrawableComponent> _IDrawableComponents = new List<IDrawableComponent>();
        private List<IUpdateableComponent> _IUpdateableComponents = new List<IUpdateableComponent>();

        //Properties
        public string Name => _name;
        public Transform Transform => _transform;


        //Constructor
        public GameObject(string pName, Transform pTransform, List<Component> testComponents)
        {
            _name = pName;
            _transform = pTransform;
            _components.AddRange(testComponents);

            for (int i = 0; i < testComponents.Count; i++)
            {
                if (testComponents[i] is IDrawableComponent _IDrawableComponent)
                {
                    _IDrawableComponents.Add(_IDrawableComponent);
                }
                if (testComponents[i] is IUpdateableComponent _IUpdateableComponent)
                {
                    _IUpdateableComponents.Add(_IUpdateableComponent);
                }
            }

        }

        public void Awake()
        {
            for (int i = 0; i < _components.Count; i++)
            {
                _components[i].Awake(this);
            }
        }

        public void Update(int Time) 
        {
            for (int i = 0; i < _IUpdateableComponents.Count; i++)
            {
                _IUpdateableComponents[i].Update(Time);
            }
        }

        public void Draw()
        {
            for (int i = 0; i < _IDrawableComponents.Count; i++)
            {
                _IDrawableComponents[i].Draw();
            }
        }

        public T GetComponent<T>() where T : Component
        {
            for (int i = 0; i < _components.Count; i++)
            {
                Component currentBehaviour = _components[i];

                if (currentBehaviour is T)
                {
                    return currentBehaviour as T;
                }

            }
            return null;
        }

        public virtual void ObjectUpdate()
        {
            //System.Diagnostics.Debug.Write("GameObjectUpdate"); 
            GetComponent<SpriteRenderer>();
        }
    }
}