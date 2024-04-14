using UnityEngine;

namespace UnityTest.WeaponSystem {
    public class Pistol : Weapon {
        private int damage;
        private int maxAmmo;
        private int ammo;
        private float shootInterval;
        private float currentShootInterval;

        private void Update() {
            HandleShootInterval();
        }

        public override void Initialize(WeaponSO so) {
            damage = so.Damage;
            maxAmmo = so.Ammo;
            ammo = maxAmmo;
            shootInterval = so.ShootingInterval;
        }

        public override void Shoot() {
            if (!CanShoot()) return;
            Debug.Log($"Riffle Shooting with {damage} Damage!");
            // Resets the shooting interval
            currentShootInterval = shootInterval;
        }

        public override void Reload() {
            ammo = maxAmmo;
        }

        private void HandleShootInterval() {
            if (currentShootInterval >= 0f)
                currentShootInterval -= Time.deltaTime;
        }

        private bool CanShoot() {
            return currentShootInterval <= 0f && ammo > 0;
        }
    }
}