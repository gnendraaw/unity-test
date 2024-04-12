namespace UnityTest.InventorySystem {
    [System.Serializable]
    public class InventorySlot {
        private ItemSO item;
        private int stack;

        public ItemSO Item => item;

        public InventorySlot(ItemSO item, int amount) {
            this.item = item;
            stack = amount;
        }

        public InventorySlot() {
            ClearItem();
        }

        public void AddItem(ItemSO itemToAdd, int amountToAdd) {
            item = itemToAdd;
            stack += amountToAdd;
        }

        public void RemoveItem(int amountToRemove) {
            stack -= amountToRemove;
            if (stack == 0)
                ClearItem();
        }

        public void ClearItem() {
            item = null;
            stack = -1;
        }
    }
}