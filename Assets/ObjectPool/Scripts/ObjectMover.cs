using UnityEngine;

namespace UnityTest.ObjectPool
{
    public class ObjectMover : MonoBehaviour
    {
        [SerializeField] private GameObject _visual;

        private ObjectPoolManager poolManager;
        private float lifeTime;
        private float speed;

        public ObjectPoolManager PoolManager
        {
            get => poolManager;
            private set { poolManager = value; }
        }

        private void Update() 
        {
            MoveObject();
            HandleLifeTime();
        }

        public void Initialize(ObjectPoolManager poolManager, ObjectModel model)
        {
            lifeTime = model.LifeTime;
            speed = model.Speed;
            PoolManager = poolManager;

            SetVisual(model.Visual);
        }

        private void SetVisual(GameObject visual)
        {
            Destroy(_visual);
            _visual = Instantiate(visual, transform);
            _visual.transform.localPosition = Vector3.zero;
        }

        private void MoveObject()
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        private void HandleLifeTime()
        {
            lifeTime -= Time.deltaTime;
            if (lifeTime <= 0f)
            {
                poolManager?.ReturnObjectToPool(gameObject);
            }
        }
    }
}