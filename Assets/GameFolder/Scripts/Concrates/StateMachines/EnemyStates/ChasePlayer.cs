using DungeonEscape.Abstracts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Concrates.StateMachines.EnemyStates
{
    public class ChasePlayer : IStates
    {
        IEntityController _entityController;
        IEntityController _player;
        IMover _mover;
        IFliper _fliper;
        IMyAnimation _myAnimation;
        public ChasePlayer(IEntityController entityController, IEntityController player,IMover mover,IFliper fliper,IMyAnimation myAnimation)
        {
            _entityController = entityController;
            _player = player;
            _mover = mover;
            _fliper = fliper;
            _myAnimation = myAnimation;
        }
        public void OnEnter()
        {
            _myAnimation.MoveAnimation(1f);
        }

        public void OnExit()
        {
            _myAnimation.MoveAnimation(0f);
        }

        public void Tick()
        {
            Vector3 leftOrRight = _player.transform.position - _entityController.transform.position;
            if (leftOrRight.x > 0)
            {
                _mover.Movement(Vector2.right);
                if (_entityController.transform.localScale.x == -1)
                {
                    _fliper.FlipCharacter(-1f);
                    Debug.Log("sað");
                }
            }
            else
            {
                _mover.Movement(-Vector2.right);   // buradan devam edielcek flip düzgün çalýþmýyor
                Debug.Log("ssol");
                if (_entityController.transform.localScale.x == 1)
                {
                    _fliper.FlipCharacter(-1f);
                    Debug.Log("ssol");
                }
            }
        }
    }
}

