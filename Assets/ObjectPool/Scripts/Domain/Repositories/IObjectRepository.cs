using UnityEngine;

namespace UnityTest.ObjectPool
{
    public interface IObjectRepository
    {
        ObjectModel GetRandomObject();
    }
}