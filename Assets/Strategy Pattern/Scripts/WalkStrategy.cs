using UnityEngine;

namespace Strategy {
    public class WalkStrategy : IMovementStrategy {
        public void Move(Transform transform, Vector3 direction, float speed) {
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}