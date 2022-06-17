using DungeonEscape.Abstracts;
using DungeonEscape.Concrates.Controllers;
using DungeonEscape.Concrates.Managers;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace DungeonEscape.Concrates.Uis
{
    public class QuestionPanel : MonoBehaviour
    {
        [SerializeField] ResultPanel resultPanel;
        TextMeshProUGUI messageText;
        int _lifeCount;
        IHealth _playerHealth;
        private void Awake()
        {
            messageText = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        }
        private void OnDisable()
        {
            _lifeCount = 0;
            _playerHealth = null;
        }
        public void SetLifeCountAndReferance(int lifeCount, IHealth playerHealth)
        {
            _lifeCount = lifeCount;
            messageText.text = $"do you want to buy {_lifeCount} hp ?";
            _playerHealth = playerHealth;
        }
        public void YesClick()
        {
            resultPanel.gameObject.SetActive(true);
            if (_lifeCount <= GameManager.Instance.Score)
            {
                resultPanel.SetResultMessage($"You have bought {_lifeCount} hp have good day. . . ");
                GameManager.Instance.DecreaseScore(_lifeCount);
                _playerHealth.Heal(_lifeCount);
            }
            else
            {
                resultPanel.SetResultMessage("you do not have enough diamond please come later");
            }
            this.gameObject.SetActive(false);
        }
    }
}
