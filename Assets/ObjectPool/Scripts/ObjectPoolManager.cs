using System.Collections.Generic;
using UnityEngine;

namespace UnityTest.ObjectPool
{
    public class ObjectPoolManager : MonoBehaviour
    {
        [SerializeField] private ObjectMover _prefab;
        [SerializeField] private int _objectCount;

        private List<ObjectMover> poolObjects;

        private void Awake()
        {
            InitializePoolObjects();
        }

        private void InitializePoolObjects()
        {
            poolObjects = new List<ObjectMover>();

            for (int i = 0; i < _objectCount; i++)
            {
                ObjectMover obj = Instantiate(_prefab);
                obj.gameObject.SetActive(false);
                poolObjects.Add(obj);
            }
        }

        public ObjectMover GetObjectFromPool()
        {
            foreach (ObjectMover obj in poolObjects)
            {
                if (!obj.gameObject.activeInHierarchy)
                {
                    obj.gameObject.SetActive(true);
                    return obj;
                }
            }

            ObjectMover newObj = Instantiate(_prefab);
            poolObjects.Add(newObj);
            return newObj;
        }

        public void ReturnObjectToPool(GameObject obj)
        {
            obj.SetActive(false);
        }
    }
}