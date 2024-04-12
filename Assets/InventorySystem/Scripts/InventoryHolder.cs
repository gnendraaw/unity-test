using UnityEngine;

namespace UnityTest.InventorySystem {
    public class InventoryHolder : MonoBehaviour {
        [SerializeField] int _inventorySize = 3;

        private InventorySystem inventorySystem;

        public InventorySystem InventorySystem => inventorySystem;

        private void Awake() {
            inventorySystem = new InventorySystem(_inventorySize);
        }

        public void AddItem(ItemSO itemToAdd, int amount) {
            inventorySystem.AddItem(itemToAdd, amount);
        }
    }
}