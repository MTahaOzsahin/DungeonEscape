using DungeonEscape.Concrates.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Concrates.Controllers
{
    public class ScoreController : MonoBehaviour
    {
        [SerializeField] int scorePoint = 10;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.GetComponent<PlayerController>() != null)
            {
                GameManager.Instance.IncreaseScore(scorePoint);
                Destroy(this.gameObject);
            }
        }
    }
}
