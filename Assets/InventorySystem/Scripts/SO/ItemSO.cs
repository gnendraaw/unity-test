using UnityEngine;

namespace UnityTest.InventorySystem {
    [CreateAssetMenu(fileName = "New Item SO", menuName = "Inventory System / Item SO")]
    public class ItemSO : ScriptableObject {
        public string Name;
        public string Description;
        public int MaxStack;
        public Sprite Sprite;
    }
}