using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Abstracts
{
    public interface IAttacker 
    {
        void Attack(ITakeHit takehit);
        int Damage { get; }
    }
}
