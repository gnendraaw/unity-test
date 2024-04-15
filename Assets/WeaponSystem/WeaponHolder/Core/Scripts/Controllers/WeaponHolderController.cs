using System;
using UnityEngine;

namespace UnityTest.WeaponSystem {
    public class WeaponHolderController : MonoBehaviour {
        public static event Action<Weapon> OnWeaponChanged;

        [SerializeField] private Transform _weaponParent;

        private Weapon currentWeapon;

        private void Update() {
            if (Input.GetKeyDown(KeyCode.J)) {
                currentWeapon.Shoot();
            }

            if (Input.GetKey(KeyCode.R)) {
                currentWeapon.Reload();
            }
        }

        public void SetWeapon(WeaponSO so) {
            currentWeapon = WeaponFactory.CreateWeapon(so, _weaponParent);
        }

        private void BroadcastSelectedWeaponChanged() {
            OnWeaponChanged?.Invoke(currentWeapon);
        }
    }
}