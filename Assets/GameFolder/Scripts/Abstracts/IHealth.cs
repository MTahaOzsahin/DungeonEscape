using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Abstracts
{
    public interface IHealth : ITakeHit
    {
        bool IsDead { get; }
        void Heal(int lifeCount);
        event System.Action<int,int> OnHealthChange;
        event System.Action OnDead;
    }
}
