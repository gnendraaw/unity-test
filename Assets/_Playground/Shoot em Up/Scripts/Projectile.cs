using UnityEngine;

namespace Playground.Shmup
{
    public class Projectile : MonoBehaviour {
        [SerializeField] private float speed;

        private Transform parent;

        public void SetSpeed(float speed) => this.speed = speed;
        public void SetParent(Transform parent) => this.parent = parent;

        private void Update() {
            transform.SetParent(null);
            transform.position += transform.up * (speed * Time.deltaTime);
        }

        private void OnCollisionEnter2D(Collision2D col) {
            // Destroy projectile
            Destroy(gameObject);
        }
    }
}