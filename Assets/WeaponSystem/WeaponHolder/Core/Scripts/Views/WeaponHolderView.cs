using UnityEngine;

namespace UnityTest.WeaponSystem {
    public class WeaponHolderView : MonoBehaviour {
        [SerializeField] private Transform _weaponParent;

        public Weapon Weapon { get; private set; }

        public void SetWeaponVisual(WeaponSO so) {
            // Destroy Previous Weapon Visual
            if (_weaponParent.childCount > 0)
                Destroy(_weaponParent.GetChild(0).gameObject);

            Weapon = Instantiate(so.Prefab, _weaponParent);
            Weapon.Initialize(so);
            Weapon.transform.localPosition = Vector3.zero;
        }
    }
}