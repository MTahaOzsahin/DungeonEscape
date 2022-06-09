using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Abstracts
{
    public interface ITakeHit 
    {
        void TakeHit(IAttacker attacker);
    }
}
