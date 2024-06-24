using UnityEngine;

namespace Playground.Shmup
{
    public class PlayerWeapon : Weapon {
        private float fireTimer;

        private void OnEnable() => InputReader.onFire += Fire;
        private void OnDisable() => InputReader.onFire -= Fire;

        private void Start() => fireTimer = Time.time + weaponStrategy.FireRate;

        private void Fire() {
            if (Time.time >= fireTimer) {
                fireTimer = Time.time + weaponStrategy.FireRate;
                weaponStrategy.Fire(firePoint, layer);
            }
        }
    }
}