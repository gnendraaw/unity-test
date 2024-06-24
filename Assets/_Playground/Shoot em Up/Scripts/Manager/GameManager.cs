using UnityEngine;

namespace Playground.Shmup {
    public class GameManager : MonoBehaviour {
        public static GameManager Instance { get; private set; }

        [Header("SCORING")]
        private int score;

        [Header("ENEMY SPAWNER")]
        [SerializeField] private EnemySpawner enemySpawner;

        public int Score => score;

        private void Awake() {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);
        }

        private void Start() => score = 0;

        public void AddScore(int amount) {
            // TODO: Make this as events, so UI adapt when score changed
            score += amount;
            Debug.Log($"Score: {score}");
        }

        public void HandleEnemyDead(int score, int deadCount) {
            AddScore(score);
            enemySpawner.DecreaseEnemiesSpawned(deadCount);
        }
    }
}