using UnityEngine;

namespace UnityTest_ScoreCounter {
    public class DependencyInjector : MonoBehaviour {
        [Header("MANAGERS")]
        [SerializeField] private GameManager gameManager;

        [Header("CONTROLLERS")]
        [SerializeField] private ScoreCounterController scoreCounterController;

        [Header("REPOSITORIES")]
        [SerializeField] private ScoreRepository scoreRepository;

        private void Awake() {
            scoreCounterController.Initialize(gameManager: gameManager, repo: scoreRepository);
        }
    }
}