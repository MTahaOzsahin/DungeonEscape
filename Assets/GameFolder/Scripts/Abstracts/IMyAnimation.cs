using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Abstracts
{
    public interface IMyAnimation
    {
        void MoveAnimation(float moveSpeed);
        void JumpingAnimation(bool isJumping);
        void AttackingAnimation();
        void PowerAttackingAnimation();
    }
}

