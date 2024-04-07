namespace UnityTest.InventorySystem 
{
    public class IngredientModel
    {
        private int quantity;

        public string Name { get; private set; }
        public int Quantity
        {
            get => quantity;
            set 
            {
                quantity = value;
            }
        }

        public IngredientModel(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public static IngredientModel FromDTO(string name, int quantity)
        {
            return new IngredientModel(name, quantity);
        }
    }
}