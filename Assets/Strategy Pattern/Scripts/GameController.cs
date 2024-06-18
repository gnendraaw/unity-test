using UnityEngine;

namespace Strategy {
    public class GameController : MonoBehaviour {
        [Header("MONO")]
        [SerializeField] private Player _player;

        private bool isRun;

        private void Awake() {
            _player.SetStrategy(new WalkStrategy());
        }

        private void Update() {
            if (Input.GetKeyDown(KeyCode.LeftShift)) {
                isRun = !isRun;
                _player.SetStrategy(isRun ? new RunStartegy() : new WalkStrategy());
            }
        }
    }
}