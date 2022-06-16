using DungeonEscape.Concrates.Enums;
using DungeonEscape.Concrates.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Concrates.Uis
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesButton()
        {
            GameManager.Instance.SplashScreen(SceneTypeEnum.Game);
        }
        public void NoButton()
        {
            GameManager.Instance.SplashScreen(SceneTypeEnum.Menu);
        }
    }
}
