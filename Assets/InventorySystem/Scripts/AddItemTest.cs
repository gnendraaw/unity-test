using UnityEngine;

namespace UnityTest.InventorySystem {
    public class AddItemTest : MonoBehaviour {
        [SerializeField] private ItemSO _item;
        [SerializeField] private InventoryHolder _inventoryHolder;

        public void Update() {
            if (Input.GetKeyDown(KeyCode.T)) {
                AddItem();
            }
        }

        private void AddItem() {
            _inventoryHolder.AddItem(_item, Random.Range(1, 5));
        }
    }
}