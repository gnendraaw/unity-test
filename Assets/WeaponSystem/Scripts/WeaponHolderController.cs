using System;
using UnityEngine;

namespace UnityTest.WeaponSystem {
    public class WeaponHolderController : MonoBehaviour {
        public static event Action<Weapon> OnWeaponChanged;

        [SerializeField] private Transform _weaponPrefab;

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
            if (_weaponPrefab.childCount > 0) {
                Destroy(_weaponPrefab.GetChild(0).gameObject);
            }
            currentWeapon = Instantiate(so.Prefab, _weaponPrefab);
            currentWeapon.Initialize(so);
            currentWeapon.transform.localPosition = Vector3.zero;

            BroadcastSelectedWeaponChanged();
        }

        private void BroadcastSelectedWeaponChanged() {

        }
    }
}