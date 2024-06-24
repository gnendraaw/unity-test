using UnityEngine;

namespace Playground.Shmup
{
    public class Projectile : MonoBehaviour {
        [SerializeField] private float speed;

        private Transform parent;
        private int damage;

        public void SetSpeed(float speed) => this.speed = speed;
        public void SetParent(Transform parent) => this.parent = parent;
        public void SetDamage (int damage) => this.damage = damage;

        private void Update() {
            transform.SetParent(null);
            transform.position += transform.up * (speed * Time.deltaTime);
        }

        private void OnCollisionEnter2D(Collision2D col) {
            if (col.gameObject.TryGetComponent(out Plane plane)){ 
                plane.TakeDamage(damage); // Update this
            }

            Destroy(gameObject);
        }
    }
}