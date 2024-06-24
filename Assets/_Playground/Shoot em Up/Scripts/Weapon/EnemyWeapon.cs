using UnityEngine;

namespace Playground.Shmup
{
    public class EnemyWeapon : Weapon {
        private float fireTimer;

        private void Update() {
            fireTimer += Time.deltaTime;
            if (fireTimer >= weaponStrategy.FireRate) {
                fireTimer = 0f;
                weaponStrategy.Fire(firePoint, layer);
            }
        }
    }
}