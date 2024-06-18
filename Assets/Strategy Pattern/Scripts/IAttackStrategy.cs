using UnityEngine;

namespace Strategy {
    public interface IAttackStrategy {
        void Attack(Transform parent, Vector3 position);
    }
}