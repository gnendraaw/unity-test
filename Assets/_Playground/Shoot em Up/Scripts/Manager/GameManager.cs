using Playground.Helpers;
using UnityEngine;

namespace Playground.Shmup {
    public class GameManager : MonoBehaviour {
        public static GameManager Instance { get; private set; }

        [Header("SCORING")]
        private int score;

        [Header("ENEMY SPAWNER")]
        [SerializeField] private EnemySpawner enemySpawner;

        [Header("PLAYER")]
        [SerializeField] private PlayerPlane playerPlane;

        [Header("UI")]
        [SerializeField] private GameObject gameOverUI;

        [Header("GAME OVER")]
        [SerializeField] private float restartInterval; // Time before the game restarts after game over

        private float gameOverTimer;

        public int Score => score;

        private void Awake() {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);
        }

        private void Start()
        {
            score = 0;
            gameOverTimer = restartInterval;
        }

        private void Update() {
            if (IsGameOver()) {
                gameOverUI.SetActive(true);
                // TODO: Restart to main menu after certain amount of time
                gameOverTimer -= Time.deltaTime;
                if (gameOverTimer <= 0f ) {
                    SceneLoader.LoadScene(SceneName.ShmupMainMenuScene);
                }
            }
        }

        public bool IsGameOver() => playerPlane.Health <= 0;

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