using UnityEngine;

namespace UnityTest.ObjectPool
{
    public class ObjectSpawner : MonoBehaviour
    {
        [SerializeField] private ObjectPoolManager _poolManager;
        [SerializeField] private Vector3 _spawnVector;

        private void Update() {
            if (Input.GetKeyDown(KeyCode.T))
            {
                GameObject obj = _poolManager.GetObjectFromPool();
                obj.GetComponent<ObjectMover>().Initialize(_poolManager);
                obj.transform.position = _spawnVector;
            }
        }
    }
}