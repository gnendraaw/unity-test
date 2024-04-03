using UnityEngine;

namespace UnityTest.ObjectPool
{
    [CreateAssetMenu(fileName = "New Object SO", menuName = "Object Pool / Object SO")]
    public class ObjectSO : ScriptableObject 
    {
        public GameObject Visual;
        public float LifeTime;
        public float Speed;

        public ObjectModel ToModel() => new ObjectModel(this);
    }
}