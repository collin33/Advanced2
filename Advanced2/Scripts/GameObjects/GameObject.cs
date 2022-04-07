using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

class GameObject
{
    //Fields
    private string _name;

    private Transform _transform = new Transform(new Vector2(0, 0), new Vector2((float)0.5, (float)0.5), 0, new Vector2(1, 1));

    private List<MonoBehaviour> _components = new List<MonoBehaviour>();

    //Properties
    public string Name => _name;
    public Transform Transform => _transform;


    //Constructor
    public GameObject(string pName, Transform pTransform, params MonoBehaviour[] pComponents)
    {
        _name = pName;
        _transform = pTransform;
        _components.AddRange(pComponents);
    }

    public T GetComponent<T>() where T : MonoBehaviour
    {
        for (int i = 0; i < _components.Count; i++)
        {
            MonoBehaviour currentBehaviour = _components[i];

            //Entity
            //Player -> Entity
            //Enemy -> Entity

            if (currentBehaviour.GetType() == typeof(T))
            {
                return currentBehaviour as T;
            }

        }
        return null;
    }

    public virtual void ObjectUpdate()
    {
        //System.Diagnostics.Debug.Write("GameObjectUpdate"); 
    }
}