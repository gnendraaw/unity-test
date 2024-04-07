using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace UnityTest.InventorySystem 
{
    public class InventoryView : MonoBehaviour 
    {
        public static event Action<string> OnIngredientSelected;

        [SerializeField] private Transform _buttonPanel;
        [SerializeField] private InventoryManager _inventoryManager;
        [SerializeField] private SelectIngredientUI _selectIngredientUI;

        private void Awake() 
        {
            InventoryManager.OnIngredientChanged += UpdateUIs;
            InitializeUIs();
        }

        private void OnDestroy() 
        {
            InventoryManager.OnIngredientChanged -= UpdateUIs;
        }

        private List<SelectIngredientUI> selectIngredientUIs = new List<SelectIngredientUI>();

        private void InitializeUIs()
        {
            foreach (IngredientSO ingredient in _inventoryManager.IngredientSOs)
            {
                SelectIngredientUI ui = Instantiate(_selectIngredientUI, _buttonPanel);
                ui.Initialize(this, ingredient.Name, ingredient.Sprite);
                ui.gameObject.SetActive(false);
                selectIngredientUIs.Add(ui);
            }
        }

        private void UpdateUIs(string name, int quantity)
        {
            var result = selectIngredientUIs.FirstOrDefault(x => x.Name == name);
            result.SetQtyText(quantity.ToString());

            if (quantity > 0)
            {
                result.gameObject.SetActive(true);
            }
            else 
            {
                result.gameObject.SetActive(false);
            }
        }

        public void SelectIngredient(string name)
        {
            OnIngredientSelected?.Invoke(name);
        }
    }
}