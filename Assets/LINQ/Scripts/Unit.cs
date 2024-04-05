namespace UnityTest.LINQ {
    public class Unit {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int Damage { get; private set; }

        public Unit(string name, int health, int damage) {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public UnitModel ToModel() => new UnitModel(Name, Health, Damage);
    }
}