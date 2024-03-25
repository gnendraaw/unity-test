using UnityEngine;

namespace UnityTest_ScoreCounter {
    public class ScoreRepositoryImpl : ScoreRepository
    {
        private const string HIGH_SCORE_KEY = "HIGH_SCORE";

        private int _highScore;

        private void Awake() {
            _highScore = PlayerPrefs.GetInt(HIGH_SCORE_KEY, 0);
        }

        public override int GetHighScore() {
            return _highScore;
        }

        public override void UpdateHighScore(int highScore) {
            _highScore = highScore;
            SaveHighScore();
        }

        private void SaveHighScore() {
            PlayerPrefs.SetInt(HIGH_SCORE_KEY, _highScore);
            PlayerPrefs.Save();
        }
    }
}