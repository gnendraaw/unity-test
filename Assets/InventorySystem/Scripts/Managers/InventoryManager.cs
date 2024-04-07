using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityTest.InventorySystem 
{
    public class InventoryManager : MonoBehaviour 
    {
        public static event Action OnIngredientAdded;
        public static event Action<IngredientModel> OnIngredientSelected;
        public static event Action<string, int> OnIngredientChanged;

        [SerializeField] private IngredientListSO _ingredientListSO;
        [SerializeField] private IngredientRepository _repo;

        public List<IngredientSO> IngredientSOs => _ingredientListSO.ingredientSOs;
        public List<IngredientModel> IngredientModels => _repo.GetIngredientModels();

        private IngredientModel selectedIngredient = null;

        private void Awake()
        {
            InventoryView.OnIngredientSelected += SelectIngredient;
        }

        private void OnDestroy()
        {
            InventoryView.OnIngredientSelected -= SelectIngredient;
        }

        private void SelectIngredient(string name)
        {
            Debug.Log($"{name} Selected!");
            selectedIngredient = _repo.GetIngredientByName(name);
            DecreaseIngredient(selectedIngredient, 1);
        }

        public void AddIngredient(string name, int quantity) 
        {
            _repo.AddIngredient(name, quantity);
            OnIngredientChanged?.Invoke(name, quantity);
        }

        public void DecreaseIngredient(IngredientModel ingredient, int amount)
        {
            ingredient.Quantity -= amount;
            _repo.ModifyIngredient(ingredient.Name, ingredient.Quantity);
            OnIngredientChanged?.Invoke(ingredient.Name, ingredient.Quantity);
        }
    }
}