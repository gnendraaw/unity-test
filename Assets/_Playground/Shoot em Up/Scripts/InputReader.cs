using UnityEngine;

namespace Playground.Shmup {
    public class InputReader : MonoBehaviour {
        public delegate void OnMove(Vector3 direction);
        public static event OnMove onMove;

        private void Update() => HandleMoveInput();

        private void HandleMoveInput() {
            Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            if (direction != Vector3.zero) onMove?.Invoke(direction);
        }
    }
}