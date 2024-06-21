using UnityEngine;

namespace Strategy {
    public class Hero : MonoBehaviour {
        [Header("SKILL")]
        [SerializeField] private FireballStrategy fireballStrategy;
        [SerializeField] private HealStrategy healStrategy;

        [Header("HEALTH")]
        [SerializeField] private int maxHealth;

        private int health;

        private void Awake() {
            health = maxHealth;
        }

        private void OnEnable() {
            SpellButton.onButtonClick += CastSkill;
        }

        private void OnDisable() {
            SpellButton.onButtonClick -= CastSkill;
        }

        public void CastSkill(Spell spell) {
            switch (spell) {
                case Spell.Fireball:
                    fireballStrategy.CastSkill(transform);
                    break;
                case Spell.Buff:
                    healStrategy.CastSkill(transform);
                    break;
            }
        }

        public void AddHealth(int amount) {
            health += amount;
            Debug.Log($"Health Added; Current Health {health}");
        }
    }

    [System.Serializable] 
    public enum Spell {
        Fireball,
        Buff
    }
}