using DungeonEscape.Abstracts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Concrates.StateMachines.EnemyStates
{
    public class Walk : IStates
    {
        IMover _mover;
        IMyAnimation _animation;
        IEntityController _entityController;
        Vector2 _direction;
        Transform[] _patrols;
        Transform _currentPatrol;

        int _patrolIndex = 0;

        public bool IsWalking { get;private set; }
        public Walk(IEntityController entityController,IMover mover,IMyAnimation animation,params Transform[] patrols)
        {
            _entityController = entityController;
            _mover = mover;
            _animation = animation;
            _patrols = patrols;
        }
        public void OnEnter()
        {
            _direction = new Vector2(_entityController.transform.localScale.x, 0f);
            _currentPatrol = _patrols[_patrolIndex];
            _animation.MoveAnimation(1f);
            IsWalking = true;
        }

        public void OnExit()
        {
            _direction = new Vector2(_entityController.transform.localScale.x,0f);
            _animation.MoveAnimation(0f);

            _patrolIndex++;
            if (_patrolIndex >= _patrols.Length)
            {
                _patrolIndex = 0;
            }
            _currentPatrol = _patrols[_patrolIndex];
        }

        public void Tick()
        {
            if (Vector2.Distance(_entityController.transform.position,_currentPatrol.position) <= 0.2f)
            {
                IsWalking = false;
                return;
            }
            _mover.Movement(_direction);
        }
    }

}
