using UnityEngine;

namespace UnityTest_ScoreCounter {
    public abstract class ScoreRepository : MonoBehaviour {
        public abstract int GetHighScore();
        public abstract void UpdateHighScore(int highScore);
    }
}