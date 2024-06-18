using UnityEngine;

namespace Strategy {
    public class Player : MonoBehaviour {
        [Header("MOVEMENT")]
        [SerializeField] private float _speed;

        private IMovementStrategy _currentStrategy;

        private void Update() {
            HandleMovement();
        }

        private void HandleMovement() {
            float valueX = Input.GetAxisRaw("Horizontal");
            float valueY = Input.GetAxisRaw("Vertical");
            _currentStrategy.Move(transform, new Vector3(valueX, valueY), _speed);
        }

        public void SetStrategy(IMovementStrategy strategy) {
            _currentStrategy = strategy;
        }
    }
}