using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Abstracts
{
    public interface IHealth : ITakeHit
    {
        int CurrentHealth { get; }
        event System.Action OnHealthChange;
    }
}
