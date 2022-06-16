using DungeonEscape.Abstracts;
using DungeonEscape.Concrates.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DungeonEscape.Concrates.Uis
{
    public class DisplayHealth : MonoBehaviour
    {
        Image healthImage;
        IHealth health;
        private void Awake()
        {
            healthImage = GetComponent<Image>();
        }
        private void OnEnable()
        {
            health = FindObjectOfType<PlayerController>().GetComponent<IHealth>();
            health.OnHealthChange += HandleHealthChanged;
        }
        private void OnDisable()
        {
            health.OnHealthChange -= HandleHealthChanged;
            healthImage.fillAmount = 1f;
        }

        private void HandleHealthChanged(int currentHealth, int maxHealth)
        {
            healthImage.fillAmount = (float)currentHealth / (float)maxHealth;
        }
    }
}
