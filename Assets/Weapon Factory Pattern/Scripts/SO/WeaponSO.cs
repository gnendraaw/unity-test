using UnityEngine;

namespace UnityTest.WeaponFactoryPattern {
    [CreateAssetMenu(fileName = "New Weapon SO", menuName = "Weapon Factory Pattern / Weapon SO")]
    public class WeaponSO : ScriptableObject {
        public string Name;
        public Weapon Prefab;
        public int Damage;
        public int Ammo;
    }
}