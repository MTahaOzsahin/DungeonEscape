using DungeonEscape.Abstracts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Abstracts
{
    public abstract class Attacker : MonoBehaviour, IAttacker
    {
        [SerializeField] int damage = 1;

        int IAttacker.Damage => damage;

        public void Attack(ITakeHit takehit)
        {
            takehit.TakeHit(this);
        }
    }
}
