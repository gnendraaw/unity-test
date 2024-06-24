using UnityEngine;

namespace Playground.Shmup
{
    public abstract class Weapon : MonoBehaviour {
        [SerializeField] protected WeaponStrategy weaponStrategy;
        [SerializeField] protected Transform firePoint;
        [SerializeField] protected LayerMask layer;

        protected virtual void Awake() => weaponStrategy.Initialize();

        public void SetWeaponStrategy(WeaponStrategy strategy) {
            weaponStrategy = strategy;
            weaponStrategy.Initialize();
        }
    }
}