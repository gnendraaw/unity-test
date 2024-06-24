using UnityEngine;

namespace Playground.Shmup
{
    public abstract class Plane : MonoBehaviour {
        [SerializeField] protected int maxHealth;

        protected int health;
        public int Health => health;

        protected virtual void Awake() => health = maxHealth;

        public virtual void TakeDamage(int damage) {
            health -= damage;
            if (health <= 0) Die();
        }

        protected abstract void Die();
    }

    public class EnemyPlane : Plane
    {
        protected override void Die() {
            // Destroy enemy plane
            Destroy(gameObject);
        }
    }
}