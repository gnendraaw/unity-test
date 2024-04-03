using UnityEngine;

namespace UnityTest.ObjectPool
{
    public class ObjectSpawner : MonoBehaviour
    {
        [SerializeField] private ObjectPoolManager _poolManager;
        [SerializeField] private Vector3 _spawnVector;

        private IObjectRepository repo;

        private void Awake()
        {
            repo = GetComponent<IObjectRepository>();
        }

        private void Update() 
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                ObjectMover obj = _poolManager.GetObjectFromPool();

                obj.Initialize(
                    poolManager: _poolManager,
                    model: repo?.GetRandomObject()
                );

                obj.transform.position = _spawnVector;
            }
        }
    }
}