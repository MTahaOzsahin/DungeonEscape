using DungeonEscape.Abstracts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Concrates.Animations
{
    public class CharacterAnimations: IMyAnimation
    {
        Animator _animator;

        public CharacterAnimations(Animator animator)
        {
            _animator = animator;
        }

        public void AttackingAnimation()
        {
            _animator.SetTrigger("attacking");
        }
        public void PowerAttackingAnimation()
        {
            _animator.SetTrigger("powerAttacking");
        }
        public void JumpingAnimation(bool isJumping)
        {
            if (_animator.GetBool("isJumping") == isJumping) return;
            _animator.SetBool("isJumping", isJumping);
        }

        public void MoveAnimation(float moveSpeed)
        {
            _animator.SetFloat("moveSpeed", Mathf.Abs(moveSpeed));
        }

        public void TakeHitAnimation()
        {
            _animator.SetTrigger("takeHit");
        }

        public void DeadAnimation()
        {
            _animator.SetTrigger("death");
        }
    }

}