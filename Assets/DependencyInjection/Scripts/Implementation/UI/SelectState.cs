using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UnityTest_ScoreCounter {
    public class SelectState : MonoBehaviour, IStateChangedObserver {
        [Header("GAME STATE")]
        [SerializeField] private GameState state;
        [SerializeField] private Button setStateButton;
        [SerializeField] TextMeshProUGUI stateText;

        [Header("MANAGERS")]
        [SerializeField] private GameManager gameManager;

        private void Awake() {
            setStateButton.onClick.AddListener(SetState);
            gameManager?.SubscribeStateChanged(this);
        }

        private void OnDestroy() {
            gameManager?.UnsubscribeStateChanged(this);
        }

        private void SetState() {
            gameManager?.SetState(state);
        }

        public void OnStateChanged(GameState state) {
            stateText.text = state.ToString();
        }
    }
}