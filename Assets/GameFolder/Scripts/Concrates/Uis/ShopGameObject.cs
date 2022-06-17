using DungeonEscape.Abstracts;
using DungeonEscape.Concrates.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Concrates.Uis
{
    public class ShopGameObject : MonoBehaviour
    {
        [SerializeField] QuestionPanel questionPanel;
        [SerializeField] GameObject shop;

        IHealth playerHealth;

        private void OnEnable()
        {
            playerHealth = FindObjectOfType<PlayerController>().GetComponent<IHealth>();
        }
        private void OnDisable()
        {
            playerHealth = null;
        }
        public void BuyHpClick(int lifeCount)
        {
            questionPanel.gameObject.SetActive(true);
            questionPanel.SetLifeCountAndReferance(lifeCount,playerHealth);
        }
        public void IsActiveShop(bool isActive)
        {
            shop.SetActive(isActive);
        }
    }
}
