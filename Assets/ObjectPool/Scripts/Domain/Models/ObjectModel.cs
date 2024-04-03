using UnityEngine;

namespace UnityTest.ObjectPool
{
    public class ObjectModel 
    {
        public GameObject Visual { get; private set; }
        public float LifeTime { get; private set; }
        public float Speed { get; private set; }

        public ObjectModel(ObjectSO so)
        {
            Visual = so.Visual;
            LifeTime = so.LifeTime;
            Speed = so.Speed;
        }

        public ObjectModel(GameObject visual, float lifeTime, float speed)
        {
            Visual = visual;
            LifeTime = lifeTime;
            Speed = speed;
        }
    }
}