using UnityEngine;

namespace Strategy {
    public class Hero : MonoBehaviour {
        [Header("FIREBALL")]
        [SerializeField] private GameObject fireBallPrefab;
        [SerializeField] private float fireballDuration;
        
        [Header("HEAL")]
        [SerializeField] private GameObject healPrefab;
        [SerializeField] private int addHealthAmount;
        [SerializeField] private float healDuration;

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
            Vector3 spawnVector = transform.position;

            switch(spell) {
                case Spell.Fireball:
                    Vector3 pos = spawnVector + Vector3.up * 1f;
                    GameObject fireball = Instantiate(fireBallPrefab, pos, Quaternion.identity);
                    Destroy(fireball, fireballDuration);
                    Debug.Log($"Shooting Fireball!");
                    break;
                case Spell.Buff:
                    GameObject heal = Instantiate(healPrefab, spawnVector, Quaternion.identity);
                    Destroy(heal, healDuration);
                    health += addHealthAmount;
                    Debug.Log($"Healing; Current Health {health}");
                    break;
            }
        }
    }

    [System.Serializable] 
    public enum Spell {
        Fireball,
        Buff
    }
}