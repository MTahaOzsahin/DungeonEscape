using DungeonEscape.Abstracts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Concrates.StateMachines.EnemyStates
{
    public class Attack : IStates
    {
        IMyAnimation _myAnimation;
        IAttacker _attacker;
        IHealth _playerHealth;
        IFliper _flipper;

        System.Func<bool> _isPlayerRightSide;

        float currentAttackTime;
        float _maxAttackTime;
        public Attack(IHealth playerHealth,IFliper fliper,IMyAnimation myAnimation,IAttacker attacker,float maxAttackTime,System.Func<bool> isPlayerRightSide)
        {
            _flipper = fliper;
            _myAnimation = myAnimation;
            _attacker = attacker;
            _playerHealth = playerHealth;
            _maxAttackTime = maxAttackTime;
            _isPlayerRightSide = isPlayerRightSide;
        }
        public void OnEnter()
        {
            currentAttackTime = 0f;
        }

        public void OnExit()
        {

        }

        public void Tick()
        {
            currentAttackTime += Time.deltaTime;
            if (currentAttackTime > _maxAttackTime)
            {
                _flipper.FlipCharacter(_isPlayerRightSide.Invoke() ? 1f : -1f);
                _myAnimation.AttackingAnimation();
                _attacker.Attack(_playerHealth);
                currentAttackTime = 0f;
            }
        }
    }
}

