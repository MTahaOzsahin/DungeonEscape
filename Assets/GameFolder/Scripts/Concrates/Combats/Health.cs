using DungeonEscape.Abstracts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Concrates.Combats
{
    public class Health : MonoBehaviour, ITakeHit
    {
        [SerializeField] int maxHealth = 3;
        int currentHealth;

        private void Awake()
        {
            currentHealth = maxHealth;
        }
        public void TakeHit(IAttacker attacker)
        {
            currentHealth -= attacker.Damage;
        }
    }
}
