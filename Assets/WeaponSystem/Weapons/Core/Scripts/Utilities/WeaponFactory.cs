using UnityEngine;

namespace UnityTest.WeaponSystem {
    public static class WeaponFactory {
        public static Weapon CreateWeapon(WeaponSO so, Transform parent) {
            Weapon weapon = Object.Instantiate(so.Prefab, parent);
            weapon.Initialize(so);
            weapon.transform.localPosition = Vector3.zero;
            return weapon;
        }
    }
}