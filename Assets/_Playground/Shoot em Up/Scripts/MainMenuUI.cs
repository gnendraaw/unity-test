using Playground.Helpers;
using UnityEngine;
using UnityEngine.UI;

namespace Playground.Shmup
{
    public class MainMenuUI : MonoBehaviour {
        [SerializeField] private Button playButton;
        [SerializeField] private Button quitButton;

        private void Awake() {
            playButton.onClick.AddListener(() => SceneLoader.LoadScene(SceneName.ShmupLevel1Scene));
            playButton.onClick.AddListener(() => Application.Quit());
        }
    }
}