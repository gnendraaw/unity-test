using UnityEngine;

namespace UnityTest.InventorySystem
{
    [CreateAssetMenu(fileName = "New Ingredient SO", menuName = "Inventory System / Ingredient SO")]
    public class IngredientSO : ScriptableObject 
    {
        public string Name;
        public GameObject Prefab;
        public Sprite Sprite;
    }
}