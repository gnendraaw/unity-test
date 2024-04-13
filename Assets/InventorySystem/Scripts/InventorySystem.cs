using UnityEngine;
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
            // Search for the first slot with the same item & enough stack left or empty slot
            while (amount > 0) {
                var targetSlot = inventorySlots.FirstOrDefault(slot => slot.Item == item && !slot.IsFull || slot.Item == null);
                targetSlot.AddItem(item, amount, out int remainingAmount);
                amount = remainingAmount;
            }
        }
    }
}