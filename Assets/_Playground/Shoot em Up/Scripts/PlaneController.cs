using UnityEngine;

namespace Playground.Shmup {
    public class PlaneController : MonoBehaviour {
        [Header("MOVEMENT")]
        [SerializeField] private float moveSpeed = 7f;

        [Header("MOVEMENT RANGE")]
        [SerializeField] private float minX = -8f;
        [SerializeField] private float maxX = 8f;
        [SerializeField] private float minY = -5f;
        [SerializeField] private float maxY = 5f;

        private void Update() => MovePosition(GetMoveDirection());
        private void MovePosition(Vector3 direction) => transform.position = ClampPosition(CalculateTargetPosition(direction));
        private Vector3 GetMoveDirection() => new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        private Vector3 CalculateTargetPosition(Vector3 direction) => transform.position + direction * moveSpeed * Time.deltaTime;

        private Vector3 ClampPosition(Vector3 position) {
            position.x = Mathf.Clamp(position.x,  minX, maxX);
            position.y = Mathf.Clamp(position.y, minY, maxY);
            return position;
        }        
    }
}