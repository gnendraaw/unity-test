using UnityEngine;

namespace Strategy {
    public interface IMovementStrategy {
        void Move(Transform transform, Vector3 direction, float speed);
    }
}