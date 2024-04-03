using UnityEngine;

namespace UnityTest.ObjectPool
{
    public class ObjectMover : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _lifeTime;

        private ObjectPoolManager poolManager;
        private float currentLifeTime;

        private void Update() 
        {
            MoveObject();
            HandleLifeTime();
        }

        public void Initialize(ObjectPoolManager poolManager)
        {
            this.poolManager = poolManager;
            currentLifeTime = _lifeTime;
        }

        private void MoveObject()
        {
            transform.Translate(Vector3.left * _speed * Time.deltaTime);
        }

        private void HandleLifeTime()
        {
            currentLifeTime -= Time.deltaTime;
            if (currentLifeTime <= 0f)
            {
                poolManager.ReturnObjectToPool(gameObject);
            }
        }
    }
}