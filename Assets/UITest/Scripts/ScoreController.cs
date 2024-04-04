using System.Collections.Generic;
using UnityEngine;

namespace UnityTest.UITest {
    public class ScoreController : MonoBehaviour {
        [SerializeField] private float _addRate = 1f;
        [SerializeField] private int _addAmount = 1;

        private int score;
        private float addRate;

        public int Score {
            get => score;
            private set {
                score = value;
                BroadcastScoreChanged(score);
            }
        }

        private void Update() {
            addRate += Time.deltaTime;
            if (addRate >= _addRate) {
                addRate = 0f;
                Score += _addAmount;
            }
        }

        private List<IScoreChangedObserver> scoreChangedObservers = new List<IScoreChangedObserver>();

        public void SubscribeScoreChanged(IScoreChangedObserver observer) {
            if (!scoreChangedObservers.Contains(observer))
                scoreChangedObservers.Add(observer);
        }

        public void UnsubscribeScoreChanged(IScoreChangedObserver observer) {
            if (scoreChangedObservers.Contains(observer))
                scoreChangedObservers.Remove(observer);
        }

        public void BroadcastScoreChanged(int score) {
            foreach (IScoreChangedObserver observer in scoreChangedObservers) {
                observer.OnScoreChanged(score);
            }
        }
    }

    public interface IScoreChangedObserver {
        void OnScoreChanged(int score);
    }
}