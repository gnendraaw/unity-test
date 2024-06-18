using UnityEngine;

namespace Strategy {
    public class BombStrategy : IAttackStrategy {
        private GameObject bullet;

        public BombStrategy(GameObject bullet) {
            this.bullet = bullet;
        }

        public void Attack(Transform parent, Vector3 position) {
            GameObject instance = Object.Instantiate(bullet, parent);
            instance.transform.position = position;
            instance.transform.rotation = parent.rotation;
        }
    }
}