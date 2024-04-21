using UnityEngine;

namespace UnityTest.WeaponFactoryPattern {
    public class WeaponHolder : MonoBehaviour, IWeaponChangeObserver {
        [SerializeField] private Transform _weaponParent;

        private Weapon currentWeapon;

        private void Start() {
            WeaponCollectionManager.Instance.RegisterObserver(this);
        }

        private void OnDestroy() {
            WeaponCollectionManager.Instance.UnregisterObserver(this);
        }

        private void Update() {
            if (Input.GetKeyDown(KeyCode.J)) {
                currentWeapon?.Use();
            }
        }

        public void OnWeaponChange(WeaponSO so) {
            ChangeWeapon(so);
        }

        public void ChangeWeapon(WeaponSO so) {
            if (_weaponParent == null) return;

            // Clear previous weapon visual
            if (_weaponParent.childCount > 0) {
                Destroy(_weaponParent.GetChild(0).gameObject);
            }

            // Create weapon & spawn new weapon visual
            currentWeapon = WeaponFactory.CreateWeapon(so, _weaponParent);
        }
    }
}