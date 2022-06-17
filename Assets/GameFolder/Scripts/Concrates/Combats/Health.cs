using DungeonEscape.Abstracts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Concrates.Combats
{
    public class Health : MonoBehaviour, IHealth
    {
        [SerializeField] int maxHealth = 3;
        [SerializeField] int currentHealth;

        public bool IsDead => currentHealth < 1;

        public event System.Action<int,int> OnHealthChange;
        public event System.Action OnDead;

        private void Awake()
        {
            currentHealth = maxHealth;
        }
        public void TakeHit(IAttacker attacker)
        {
            if (IsDead) return;
            currentHealth = Mathf.Max(currentHealth -= attacker.Damage,0);
            OnHealthChange?.Invoke(currentHealth,maxHealth);

            if (IsDead) OnDead?.Invoke();
        }
        public void Heal(int lifeCount)
        {
            currentHealth = Mathf.Min(currentHealth += lifeCount, maxHealth);
            OnHealthChange?.Invoke(currentHealth, maxHealth);
        }
    }
}
