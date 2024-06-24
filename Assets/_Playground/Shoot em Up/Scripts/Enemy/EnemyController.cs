using UnityEngine;

namespace Playground.Shmup {
    public class EnemyController : MonoBehaviour {
        private GameObject prefab;
        private GameObject weapon;
        private float moveSpeed;

        public GameObject Prefab { get => prefab; set => prefab = value; }
        public GameObject Weapon { get => weapon; set => weapon = value; }
        public float MoveSpeed { get => moveSpeed; set => moveSpeed = value; }

        private void Update() {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
    }
}