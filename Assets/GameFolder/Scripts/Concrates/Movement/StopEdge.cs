using DungeonEscape.Abstracts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Concrates.Movement
{
    [RequireComponent(typeof(Collider2D))]
    public class StopEdge : MonoBehaviour , IStopEdge
    {
        [SerializeField] float distance = 0.1f;
        [SerializeField] LayerMask layerMask;

        Collider2D enemyCollider;
        float direction;

        private void Awake()
        {
            enemyCollider = GetComponent<Collider2D>();
            direction = transform.localScale.x;
        }

        public bool ReachEdge()
        {
            float x = GetXPosition();
                
            float y = enemyCollider.bounds.min.y;

            Vector2 origin = new Vector2(x, y);

            RaycastHit2D hit = Physics2D.Raycast(origin, Vector2.down, distance, layerMask);
            Debug.DrawRay(origin, Vector2.down * distance, Color.red);

            if (hit.collider != null)
            {
                direction *= transform.localScale.x;
                return false;
            }
            return true;
        }

        private float GetXPosition()
        {
            return direction == 1f ? enemyCollider.bounds.max.x + 0.1f : enemyCollider.bounds.min.x - 0.1f;
        }
    }
}
