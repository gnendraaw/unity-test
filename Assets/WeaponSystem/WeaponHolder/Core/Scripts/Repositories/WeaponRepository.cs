using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace UnityTest.WeaponSystem {
    public class WeaponRepository : MonoBehaviour {
        [SerializeField] private List<WeaponSO> _weapons = new List<WeaponSO>();

        public WeaponSO GetWeapon(string name) {
            var result = _weapons.FirstOrDefault(weapon => weapon.Name == name);
            return result;
        }
    }
}