namespace UnityTest.InventorySystem {
    [System.Serializable]
    public class InventorySlot {
        private ItemSO item;
        private int stack;

        public ItemSO Item => item;
        public int Stack => stack;
        public bool IsFull => stack == item.MaxStack;

        public InventorySlot(ItemSO item, int amount) {
            this.item = item;
            stack = amount;
        }

        public InventorySlot() {
            ClearItem();
        }

        public void AddItem(ItemSO itemToAdd, int amountToAdd, out int amountRemaining) {
            item = itemToAdd;

            int spaceLeft = item.MaxStack - stack;

            if (spaceLeft >= amountToAdd) {
                stack += amountToAdd;
                amountRemaining = 0;
            } else {
                stack = item.MaxStack;
                amountRemaining = amountToAdd - spaceLeft;
            }
        }

        public void RemoveItem(int amountToRemove) {
            stack -= amountToRemove;
            if (stack == 0)
                ClearItem();
        }

        public void ClearItem() {
            item = null;
            stack = 0;
        }
    }
}