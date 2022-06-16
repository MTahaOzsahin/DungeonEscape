using DungeonEscape.Concrates.Enums;
using DungeonEscape.Concrates.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Concrates.Uis
{
    public class MenuButtonObject : MonoBehaviour
    {
        public void StartGame()
        {
            GameManager.Instance.SplashScreen(SceneTypeEnum.Game);
        }
        public void QuitGame()
        {
            GameManager.Instance.QuitGame();
        }
    }
}