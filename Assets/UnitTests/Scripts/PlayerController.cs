using UnityEngine;

namespace UnityTest.UnitTest {
    public class PlayerController : MonoBehaviour {
        private int _health;

        public int Health => _health;

        public void Initialize(int health) {
            _health = health;
        }

        public void TakeDamage(int damage) {
            _health -= damage;
            Debug.Log($"Remaining Health: {_health}");
            if (_health <= 0) {
                Debug.Log("Player Died");
            }
        }
    }
}