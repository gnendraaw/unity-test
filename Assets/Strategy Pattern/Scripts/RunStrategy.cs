using UnityEngine;

namespace Strategy {
    public class RunStartegy : IMovementStrategy {
        public void Move(Transform transform, Vector3 direction, float speed) {
            transform.position += direction * speed * 1.618f * Time.deltaTime;
        }
    }
}