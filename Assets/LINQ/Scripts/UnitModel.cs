using System;

namespace UnityTest.LINQ {
    public class UnitModel {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int Damage { get; private set; }

        public UnitModel(string name, int health, int damage) {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public static UnitModel FromStats(Stats stats) => new UnitModel(
            name: stats.Name,
            health: stats.Health,
            damage: stats.Damage
        );

        public Unit ToEntity() => new Unit(Name, Health, Damage);
    }

    [Serializable]
    public struct Stats {
        public string Name;
        public int Health;
        public int Damage;
    }
}