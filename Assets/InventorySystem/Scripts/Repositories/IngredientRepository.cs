using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace UnityTest.InventorySystem
{
    public class IngredientRepository : MonoBehaviour
    {
        private List<IngredientModel> ingredientModels = new List<IngredientModel>();

        public List<IngredientModel> GetIngredientModels() => ingredientModels;

        public void AddIngredient(IngredientModel ingredient)
        {
            var result = ingredientModels.FirstOrDefault(x => x.Name == ingredient.Name);

            // If no ingredient found, create and add a new one
            if (result == null)
            {
                ingredientModels.Add(ingredient);
                Debug.Log($"New Ingredient Added! {ingredient.Name}; {ingredient.Quantity}");
                return;
            }

            result.Quantity += ingredient.Quantity;
            Debug.Log($"Ingredient Updated! {ingredient.Name}; {ingredient.Quantity}");
        }

        public void AddIngredient(string name, int quantity)
        {
            var result = ingredientModels.FirstOrDefault(x => x.Name == name);

            // If no ingredient found, create a new one
            if (result == null)
            {
                ingredientModels.Add(IngredientModel.FromDTO(name, quantity));
                Debug.Log($"New Ingredient Added! {name}; {quantity}");
                return;
            }

            result.Quantity += quantity;
            Debug.Log($"Ingrediend Updated! {name}; {result.Quantity}");
        }

        public IngredientModel GetIngredientByName(string name)
        {
            var result = ingredientModels.FirstOrDefault(x => x.Name == name);
            return result;
        }

        public void ModifyIngredient(string name, int quantity)
        {
            var result = ingredientModels.FirstOrDefault(x => x.Name == name);
            result.Quantity = quantity;
        }
    }
}