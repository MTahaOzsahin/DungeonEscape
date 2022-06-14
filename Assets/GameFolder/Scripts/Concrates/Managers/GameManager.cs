using DungeonEscape.Concrates.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DungeonEscape.Concrates.Managers
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] int score;
        public static GameManager Instance { get;private set; }

        public event System.Action<SceneTypeEnum> OnSceneChanged;
        private void Awake()
        {
            SingletonThisObjrct();
        }
        void SingletonThisObjrct()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
        public void SplashScreen(string sceneName)
        {
            SceneTypeEnum sceneType;
            switch (sceneName)
            {
                case "Game":
                    sceneType = SceneTypeEnum.Game;
                    break;
                case "SplashScreen":
                    sceneType = SceneTypeEnum.Splash;
                    break;
                default:
                    sceneType = SceneTypeEnum.Menu;
                    break;
            }
            StartCoroutine(SplashScreenAsync(sceneName,sceneType));
        }
        IEnumerator SplashScreenAsync(string sceneName,SceneTypeEnum sceneType)
        {
            yield return SceneManager.LoadSceneAsync("SplashScreen", LoadSceneMode.Additive);
            OnSceneChanged?.Invoke(SceneTypeEnum.Splash);

            yield return SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("SplashScreen"));

            yield return new WaitForSeconds(3f);

            yield return SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
            yield return SceneManager.LoadSceneAsync(sceneName,LoadSceneMode.Additive);

            OnSceneChanged.Invoke(sceneType);

            SceneManager.SetActiveScene(SceneManager.GetSceneByName(sceneName));
        }
        public void QuitGame()
        {
            Application.Quit();
        }
    }
}
