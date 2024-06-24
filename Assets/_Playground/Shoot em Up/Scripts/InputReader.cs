using UnityEngine;

namespace Playground.Shmup {
    public class InputReader : MonoBehaviour {
        public delegate void OnMove(Vector3 direction);
        public static event OnMove onMove;

        public delegate void OnFire();
        public static event OnFire onFire;

        private void Update() {
            HandleMoveInput();
            HandleFireInput();
        }

        private void HandleMoveInput() {
            Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            if (direction != Vector3.zero) onMove?.Invoke(direction);
        }

        private void HandleFireInput() {
            if (Input.GetKeyDown(KeyCode.Space)) onFire?.Invoke();
        }
    }
}