using UnityEngine;

namespace Strategy {
    public class Bullet : MonoBehaviour {
        [Header("MOVEMENT")]
        [SerializeField] private float _speed;

        private void Update() {
            HandleMovement();
        }

        private void HandleMovement() {
            transform.Translate(Vector3.up * _speed * Time.deltaTime);
        }
    }
}