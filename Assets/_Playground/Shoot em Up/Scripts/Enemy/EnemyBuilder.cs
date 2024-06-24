using UnityEngine;

namespace Playground.Shmup
{
    public class EnemyBuilder {
        private GameObject enemyPrefab;
        private GameObject weapon;
        private float moveSpeed;

        public EnemyBuilder SetPrefab(GameObject prefab) {
            enemyPrefab = prefab;
            return this;
        }

        public EnemyBuilder SetWeapon(GameObject weapon) {
            this.weapon = weapon;
            return this;
        }

        public EnemyBuilder SetMoveSpeed(float moveSpeed) {
            this.moveSpeed = moveSpeed;
            return this;
        }

        public GameObject Build() {
            GameObject instance = GameObject.Instantiate(enemyPrefab);
            
            EnemyController enemyController = instance.GetComponent<EnemyController>();
            if (enemyController == null) instance.AddComponent<EnemyController>();

            enemyController.Prefab = enemyPrefab;
            enemyController.Weapon = weapon;
            enemyController.MoveSpeed = moveSpeed;

            return instance;
        }
    }
}