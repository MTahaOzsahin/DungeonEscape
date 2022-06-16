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
        public event System.Action<int> OnScoreChanged;
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
        public void SplashScreen(SceneTypeEnum sceneTypeEnum)
        {
            StartCoroutine(SplashScreenAsync(sceneTypeEnum));
        }
        IEnumerator SplashScreenAsync(SceneTypeEnum sceneType)
        {
            yield return SceneManager.LoadSceneAsync(SceneTypeEnum.SplashScreen.ToString(), LoadSceneMode.Additive);
            OnSceneChanged?.Invoke(SceneTypeEnum. SplashScreen);

            yield return SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("SplashScreen"));

            yield return new WaitForSeconds(3f);

            yield return SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
            yield return SceneManager.LoadSceneAsync(sceneType.ToString(),LoadSceneMode.Additive);

            OnSceneChanged.Invoke(sceneType);

            SceneManager.SetActiveScene(SceneManager.GetSceneByName(sceneType.ToString()));
        }
        public void QuitGame()
        {
            Application.Quit();
        }
        public void IncreaseScore(int scorePoint)
        {
            score += scorePoint;
            OnScoreChanged?.Invoke(score);
        }
    }
}
