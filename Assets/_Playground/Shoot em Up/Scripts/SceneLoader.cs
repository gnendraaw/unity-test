using UnityEngine.SceneManagement;

namespace Playground.Helpers {
    public static class SceneLoader {
        private const string SceneLoadingName = "ShmupLoadingScene";

        private static SceneName targetScene;

        public static void LoadScene(SceneName targetScene) {
            SceneLoader.targetScene = targetScene;
            SceneManager.LoadScene(SceneLoadingName);
        }

        public static void LoadSceneCallback() {
            SceneManager.LoadScene(targetScene.ToString());
        }
    }

    [System.Serializable] 
    public enum SceneName {
        ShmupMainMenuScene,
        ShmupLevel1Scene
    }
}