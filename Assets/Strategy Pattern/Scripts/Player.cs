using UnityEngine;

namespace Strategy {
    public class Player : MonoBehaviour {
        [Header("MOVEMENT")]
        [SerializeField] private float _speed;

        [Header("ATTACK")]
        [SerializeField] private Transform _bulletParent;
        [SerializeField] private Transform _bulletSpawnPos;

        private IMovementStrategy _currentStrategy;
        private IAttackStrategy _attackStrategy;

        private void Update() {
            HandleMovement();
            HandleAttack();
            HandleRotation();
        }

        private void HandleMovement() {
            if (_currentStrategy == null) {
                Debug.LogError($"Current Strategy is NULL");
                return;
            }

            float valueX = Input.GetAxisRaw("Horizontal");
            float valueY = Input.GetAxisRaw("Vertical");
            _currentStrategy.Move(transform, new Vector3(valueX, valueY), _speed);
        }

        private void HandleAttack() {
            if (_attackStrategy == null) {
                Debug.LogError($"Attack Strategy is NULL");
                return;
            }

            if (Input.GetKeyDown(KeyCode.Space)) {
                _attackStrategy.Attack(transform, _bulletSpawnPos.position);
            }
        }

        private void HandleRotation() {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 direction = mousePosition - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
            transform.rotation = Quaternion.Euler(0f, 0f, angle);
        }

        public void SetStrategy(IMovementStrategy strategy) {
            _currentStrategy = strategy;
        }

        public void SetAttackStrategy(IAttackStrategy attackStrategy) {
            _attackStrategy = attackStrategy;
        }
    }
}