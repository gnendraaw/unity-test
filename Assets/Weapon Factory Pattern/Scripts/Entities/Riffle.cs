using UnityEngine;

namespace UnityTest.WeaponFactoryPattern {
    public class Riffle : Weapon {
        public override void Use() {
            Debug.Log($"Shooting bullet with {damage} damage!");

            ammo -= 1;
            Debug.Log($"Remaining ammo: {ammo}");
        }

        public override void Initialize(WeaponSO so) {
            weaponName = so.Name;
            damage = so.Damage;
            ammo = so.Ammo;
        }
    }
}