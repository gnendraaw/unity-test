using UnityEngine;

namespace UnityTest.WeaponSystem {
    public class WeaponChanger : MonoBehaviour {
        [SerializeField] private WeaponSO _weapon;
        [SerializeField] private WeaponHolderController _weaponHolder;

        public void SetWeapon() {
            _weaponHolder.SetWeapon(_weapon);
        }
    }
}