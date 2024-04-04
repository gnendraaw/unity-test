using UnityEngine;
using TMPro;

namespace UnityTest.UITest {
    public class ScoreUI : MonoBehaviour, IScoreChangedObserver {
        [SerializeField] private TextMeshProUGUI _scoreText;
        [SerializeField] private ScoreController _scoreController;

        private void Awake() {
            _scoreController.SubscribeScoreChanged(this);
        }

        private void OnDestroy() {
            _scoreController.UnsubscribeScoreChanged(this);
        }

        public void OnScoreChanged(int score) {
            SetScoreText(score);
        }

        public void SetScoreText(int score) {
            _scoreText.text = score.ToString();
        }
    }
}