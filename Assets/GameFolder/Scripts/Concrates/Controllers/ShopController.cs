using DungeonEscape.Concrates.Uis;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Concrates.Controllers
{
    public class ShopController : MonoBehaviour
    {
        ShopGameObject  _shopGameObject;
        private void Start()
        {
            _shopGameObject = FindObjectOfType<ShopGameObject>();
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            IsPlayerTriggered(collision, true);
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            IsPlayerTriggered(collision, false);
        }
        void IsPlayerTriggered(Collider2D collider,bool isActive)
        {
            PlayerController playerController = collider.GetComponent<PlayerController>();
            if (playerController != null)
            {
                _shopGameObject.IsActiveShop(isActive);
            }
        }
    }
}
