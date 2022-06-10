using DungeonEscape.Abstracts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Concrates.Combats
{
    public class Health : MonoBehaviour, IHealth
    {
        [SerializeField] int maxHealth = 3;
        int currentHealth;
        public int CurrentHealth => currentHealth;

        public event System.Action OnHealthChange;

        private void Awake()
        {
            currentHealth = maxHealth;
        }
        public void TakeHit(IAttacker attacker)
        {
            currentHealth -= attacker.Damage;
            OnHealthChange?.Invoke();
        }
    }
}
