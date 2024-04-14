using UnityEngine;

namespace UnityTest.WeaponSystem {
    public abstract class Weapon : MonoBehaviour {
        public abstract void Initialize(WeaponSO so);
        public abstract void Shoot();
        public abstract void Reload();
    }
}