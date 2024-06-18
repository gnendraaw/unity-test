using UnityEngine;

namespace Strategy {
    public class GameController : MonoBehaviour {
        [Header("MONO")]
        [SerializeField] private Player _player;

        [Header("ATTACK")]
        [SerializeField] private GameObject _bulletPrefab;

        private bool isRun;

        private void Awake() {
            _player.SetStrategy(new WalkStrategy());
            _player.SetAttackStrategy(new BombStrategy(_bulletPrefab));
        }

        private void Update() {
            if (Input.GetKeyDown(KeyCode.LeftShift)) {
                isRun = !isRun;
                _player.SetStrategy(isRun ? new RunStartegy() : new WalkStrategy());
            }
        }
    }
}