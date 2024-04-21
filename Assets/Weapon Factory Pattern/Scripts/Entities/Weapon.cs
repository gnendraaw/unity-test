using UnityEngine;

namespace UnityTest.WeaponFactoryPattern {
    public abstract class Weapon : MonoBehaviour {
        protected string weaponName;
        protected int damage;
        protected int ammo;

        public string WeaponName => weaponName;
        public int Damage => damage;
        public int Ammo => ammo;

        public abstract void Use();
        public abstract void Initialize(WeaponSO so);
    }
}