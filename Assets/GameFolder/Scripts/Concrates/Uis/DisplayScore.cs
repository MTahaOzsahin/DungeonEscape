using DungeonEscape.Concrates.Managers;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace DungeonEscape.Concrates.Uis
{
    public class DisplayScore : MonoBehaviour
    {
        TextMeshProUGUI scoreText;
        private void Awake()
        {
            scoreText = GetComponent<TextMeshProUGUI>();
        }
        private void Start()
        {
            HandleScoreChanged(0);
        }
        private void OnEnable()
        {
            GameManager.Instance.OnScoreChanged += HandleScoreChanged;
        }
        private void OnDisable()
        {
            GameManager.Instance.OnScoreChanged -= HandleScoreChanged;
        }

        private void HandleScoreChanged(int score)
        {
            scoreText.text = score.ToString();
        }
    }
}
