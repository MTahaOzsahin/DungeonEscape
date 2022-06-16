using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Abstracts
{
    public interface IHealth : ITakeHit
    {
        bool IsDead { get; }
        event System.Action<int,int> OnHealthChange;
        event System.Action OnDead;
    }
}
