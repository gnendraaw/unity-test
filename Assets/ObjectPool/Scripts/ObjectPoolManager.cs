using System.Collections.Generic;
using UnityEngine;

namespace UnityTest.ObjectPool
{
    public class ObjectPoolManager : MonoBehaviour
    {
        [SerializeField] private GameObject _prefab;
        [SerializeField] private int _objectCount;

        private List<GameObject> poolObjects;

        private void Awake()
        {
            InitializePoolObjects();
        }

        private void InitializePoolObjects()
        {
            poolObjects = new List<GameObject>();

            for (int i = 0; i < _objectCount; i++)
            {
                GameObject obj = Instantiate(_prefab);
                obj.SetActive(false);
                poolObjects.Add(obj);
            }
        }

        public GameObject GetObjectFromPool()
        {
            foreach (GameObject obj in poolObjects)
            {
                if (!obj.activeInHierarchy)
                {
                    obj.SetActive(true);
                    return obj;
                }
            }

            GameObject newGO = Instantiate(_prefab);
            poolObjects.Add(newGO);
            return newGO;
        }

        public void ReturnObjectToPool(GameObject obj)
        {
            obj.SetActive(false);
        }
    }
}