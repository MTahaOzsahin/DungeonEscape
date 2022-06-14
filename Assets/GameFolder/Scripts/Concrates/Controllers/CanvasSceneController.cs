using DungeonEscape.Concrates.Enums;
using DungeonEscape.Concrates.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Concrates.Controllers
{
    public class CanvasSceneController : MonoBehaviour
    {
        [SerializeField] SceneTypeEnum sceneType;
        [SerializeField] GameObject canvasObject;

        private void Start()
        {
            GameManager.Instance.OnSceneChanged += HandleSceneChanged;
        }
        private void OnDestroy()
        {
            GameManager.Instance.OnSceneChanged -= HandleSceneChanged;
        }
        private void HandleSceneChanged(SceneTypeEnum sceneType)
        {
            if (sceneType == this.sceneType)
            {
                canvasObject.SetActive(true);
            }
            else
            {
                canvasObject.SetActive(false);
            }
        }
    }
}
