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

        private List<MonoBehaviour> _components = new List<MonoBehaviour>();

        //Properties
        public string Name => _name;
        public Transform Transform => _transform;


        //Constructor
        public GameObject(string pName, Transform pTransform, List<MonoBehaviour> testComponents)
        {
            _name = pName;
            _transform = pTransform;
            _components.AddRange(testComponents);
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
            for (int i = 0; i < _components.Count; i++)
            {
                _components[i].Update(Time);
            }
        }

        public void Draw()
        {
            for (int i = 0; i < _components.Count; i++)
            {
                _components[i].Draw();
            }
        }

        public T GetComponent<T>() where T : MonoBehaviour
        {
            for (int i = 0; i < _components.Count; i++)
            {
                MonoBehaviour currentBehaviour = _components[i];

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