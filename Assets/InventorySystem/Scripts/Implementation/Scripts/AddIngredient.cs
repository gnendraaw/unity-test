using UnityEngine;
using UnityEngine.UI;

namespace UnityTest.InventorySystem
{
    public class AddIngredient : MonoBehaviour 
    {
        [Header("FOR INGREDIENTS")]
        [SerializeField] private string _name;
        [SerializeField] private int _quantity;

        [Header("MANAGERS")]
        [SerializeField] private InventoryManager _inventoryManager;

        [Header("UIS")]
        [SerializeField] private Button _addIngredientButton;

        private void Awake() 
        {
            _addIngredientButton.onClick.AddListener(AddTheIngredient);
        }

        public void AddTheIngredient()
        {
            _inventoryManager.AddIngredient(_name, _quantity);
        }
    }
}