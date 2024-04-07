using System.Collections.Generic;
using UnityEngine;

namespace UnityTest.InventorySystem 
{
    [CreateAssetMenu(fileName = "New Ingredient List SO", menuName = "Inventory System / Ingredient List SO")]
    class IngredientListSO : ScriptableObject 
    {
        public List<IngredientSO> ingredientSOs;
    }
}