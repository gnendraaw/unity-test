using UnityEngine;

namespace Playground.Shmup
{
    public abstract class WeaponStrategy : ScriptableObject {
        [SerializeField] private int damage = 10;
        [SerializeField] private float fireRate = .5f;
        [SerializeField] protected float projectileSpeed = 10f;
        [SerializeField] protected float projectileLifetime = 4f;
        [SerializeField] protected private GameObject projectilePrefab;

        public int Damage => damage;
        public float FireRate => fireRate;

        public virtual void Initialize() {
            // no-op
        }

        public abstract void Fire(Transform firePoint, LayerMask layer);
    }
}