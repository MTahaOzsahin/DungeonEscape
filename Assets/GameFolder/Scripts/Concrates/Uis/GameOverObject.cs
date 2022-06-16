using DungeonEscape.Abstracts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Concrates.Uis
{
    public class GameOverObject : MonoBehaviour
    {
        [SerializeField] GameObject gameOverPanel;

        IHealth playerHealth;

        private void OnEnable()
        {
            gameOverPanel.SetActive(false);
        }
        public void SetPlayerHealth(IHealth health)
        {
            playerHealth = health;
            playerHealth.OnDead += HandleDead;
        }
        private void HandleDead()
        {
            gameOverPanel.SetActive(true);
            playerHealth.OnDead -= HandleDead;
            playerHealth = null;
        }
    }
}
