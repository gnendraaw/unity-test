using UnityEngine;

namespace UnityTest_ScoreCounter {
    public class ScoreCounterController : MonoBehaviour, IStateChangedObserver {
        [SerializeField] private float _addRate;
        [SerializeField] private int _addScoreAmount;

        private GameManager _gameManager;
        private ScoreRepository _repo;

        private int _score;
        private int _highScore;
        private float _timer;

        public void Initialize(GameManager gameManager, ScoreRepository repo) {
            _gameManager = gameManager;
            _repo = repo;

            _gameManager?.SubscribeStateChanged(this);
        }

        private void Start() {
            StartFresh();
        }

        private void OnDestroy() {
            _gameManager?.UnsubscribeStateChanged(this);
        }

        private void StartFresh() {
            SetHighScore(_repo.GetHighScore());
            SetScore(0);
        }

        private void Update() {
            if (CanCount())
                HandleScoring();
        }

        private void HandleScoring() {
            _timer += Time.deltaTime;
            if (_timer >= _addRate) {
                _timer = 0f;
                SetScore(_score + _addScoreAmount);
            }
        }

        private void SetScore(int score) {
            _score = score;
            Debug.Log($"Score: {_score}");
        }

        private void SetHighScore(int highScore) {
            _highScore = highScore;
            Debug.Log($"HighScore: {_highScore}");
        }

        private bool CanCount() {
            return _gameManager?.State == GameState.Playing;
        }

        public void OnStateChanged(GameState state) {
            switch (state) {
                case GameState.WaitingToPlay:
                    StartFresh();
                    break;
                case GameState.GameOver:
                    HandleGameOver();
                    break;
            }
        }

        private void HandleGameOver() {
            if (_score > _highScore) {
                SetHighScore(_score);
                _repo.UpdateHighScore(_highScore);
            }
        }
    }
}