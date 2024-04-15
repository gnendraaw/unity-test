using UnityEngine;

namespace UnityTest.WeaponSystem {
    [CreateAssetMenu(fileName = "New Weapon SO", menuName = "Weapon System / Weapon SO")]
    public class WeaponSO : ScriptableObject {
        public Weapon Prefab;
        public string Name;
        [TextArea(4,2)]
        public string Description;
        public Sprite Sprite;
        public int Damage;
        public int Ammo;
        public float ShootingInterval;
    }
}