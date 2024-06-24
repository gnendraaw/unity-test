using Playground.Helpers;
using UnityEngine;

namespace Playground.Shmup {
    public class LoadingSceneCallback : MonoBehaviour {
        private bool isFirstFrame;

        private void Update()
        {
            if (isFirstFrame) SceneLoader.LoadSceneCallback();
            isFirstFrame = true;
        }
    }
}