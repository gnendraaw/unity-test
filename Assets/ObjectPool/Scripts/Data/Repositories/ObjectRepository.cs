using System.Collections.Generic;
using UnityEngine;

namespace UnityTest.ObjectPool 
{
    public class ObjectRepository : MonoBehaviour, IObjectRepository
    {
        [SerializeField] private List<ObjectSO> objectSOList = new List<ObjectSO>();

        public ObjectModel GetRandomObject() => objectSOList[Random.Range(0, objectSOList.Count)].ToModel();
    }
}