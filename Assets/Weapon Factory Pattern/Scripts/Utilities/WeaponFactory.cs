using UnityEngine;

namespace UnityTest.WeaponFactoryPattern {
    public static class WeaponFactory {
        public static Weapon CreateRiffle(WeaponSO so, Transform parent) {
            var riffle = Object.Instantiate(so.Prefab, parent);
            riffle.transform.localPosition = Vector3.zero;
            riffle.Initialize(so);
            return riffle;
        }

        public static Weapon CreateWeapon(WeaponSO so, Transform parent) {
            var weapon = Object.Instantiate(so.Prefab, parent);
            weapon.transform.localPosition = Vector3.zero;
            weapon.Initialize(so);
            return weapon;
        }
    }
}