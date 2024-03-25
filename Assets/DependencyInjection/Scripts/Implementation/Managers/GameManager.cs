using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityTest_ScoreCounter {
    public class GameManager : MonoBehaviour {
        private GameState _state;

        public GameState State { 
            get => _state;
            private set {
                if (_state != value) {
                    _state = value;
                    Debug.Log($"State: {_state}");
                    BroadcastStateChanged(_state);
                }
            }
        }

        private void Start() {
            State = GameState.WaitingToPlay;
        }

        public void SetState(GameState state) {
            State = state;
        }

        #region StateChanged
        private List<IStateChangedObserver> stateChangedObservers = new List<IStateChangedObserver>();

        public void SubscribeStateChanged(IStateChangedObserver observer) {
            if (!stateChangedObservers.Contains(observer)) {
                stateChangedObservers.Add(observer);
            }
        }

        public void UnsubscribeStateChanged(IStateChangedObserver observer) {
            if (stateChangedObservers.Contains(observer)) {
                stateChangedObservers.Remove(observer);
            }
        }

        public void BroadcastStateChanged(GameState state) {
            foreach (IStateChangedObserver observer in stateChangedObservers) {
                observer.OnStateChanged(state);
            }
        }
        #endregion
    }

    public interface IStateChangedObserver {
        void OnStateChanged(GameState state);
    }

    [Serializable]
    public enum GameState {
        WaitingToPlay,
        Playing,
        Paused,
        GameOver,
    }
}