using System.Collections.Generic;
using System.Linq;

namespace UnityTest.InventorySystem {
    [System.Serializable]
    public class InventorySystem {
        private List<InventorySlot> inventorySlots;

        public List<InventorySlot> InventorySlots => inventorySlots;

        public InventorySystem(int slotCount) {
            inventorySlots = new List<InventorySlot>(slotCount);
            for (int i = 0; i < slotCount; i++) {
                inventorySlots.Add(new InventorySlot());
            }
        }

        public void AddItem(ItemSO item, int amount) {
            for (int i = 0; i < inventorySlots.Count; i++) {
                if (inventorySlots[i].Item == null) {
                    inventorySlots[i] = new InventorySlot(item, amount);
                    return;
                }
            }
        }
    }
}