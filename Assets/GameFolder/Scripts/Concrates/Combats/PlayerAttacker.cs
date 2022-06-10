using DungeonEscape.Abstracts;
using DungeonEscape.Concrates.Animations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Concrates.Combats
{
    public class PlayerAttacker : Attacker
    {
        [SerializeField] Transform attackDirection;
        [SerializeField] float attackRadius = 0.5f;

        Collider2D[] attackResults;
        private void Awake()
        {
            attackResults = new Collider2D[10];
        }
        private void OnEnable()
        {
            GetComponent<AnimationImpactsWatcher>().OnImpact += HandleImpact;
        }
        private void OnDisable()
        {
            GetComponent<AnimationImpactsWatcher>().OnImpact -= HandleImpact;
        }
        private void HandleImpact()
        {
            int hitCount = Physics2D.OverlapCircleNonAlloc(attackDirection.position + attackDirection.forward, attackRadius, attackResults);

            for (int i = 0; i < hitCount; i++)
            {
                ITakeHit takeHit = attackResults[i].GetComponent<ITakeHit>();

                if (takeHit != null)
                {
                    Attack(takeHit);
                }
            }
        }
        private void OnDrawGizmos()
        {
            OnDrawGizmosSelected();
        }
        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(attackDirection.position + attackDirection.forward,attackRadius);
        }
    }
}
