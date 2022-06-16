using DungeonEscape.Abstracts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Concrates.StateMachines.EnemyStates
{
    public class ChasePlayer : IStates
    {
        IEntityController _enemyController;
        IMover _mover;
        IFliper _fliper;
        IMyAnimation _myAnimation;
        IStopEdge _stopEdge;
        System.Func<bool> _isPlayerRightSide;
        public ChasePlayer(IEntityController enemyController,IMover mover,IFliper fliper,IMyAnimation myAnimation,IStopEdge stopEdge,System.Func<bool> isPlayerRightSide)
        {
            _enemyController = enemyController;
            _mover = mover;
            _fliper = fliper;
            _myAnimation = myAnimation;
            _stopEdge = stopEdge;
            _isPlayerRightSide = isPlayerRightSide;
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
            if (_stopEdge.ReachEdge())
            {
                _myAnimation.MoveAnimation(0f);
                return;
            }
            if (_isPlayerRightSide.Invoke())
            {
                _mover.Movement(Vector2.right);
                _enemyController.transform.localScale = new Vector3(1f,1f,1f); 
            }
            else
            {
                _mover.Movement(-Vector2.right);
                _enemyController.transform.localScale = new Vector3(-1f, 1f, 1f); 
            }
        }
    }
}

