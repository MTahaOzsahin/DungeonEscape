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

        public void MoveAnimation(float moveSpeed)
        {
            _animator.SetFloat("moveSpeed", Mathf.Abs(moveSpeed));
        }
    }

}