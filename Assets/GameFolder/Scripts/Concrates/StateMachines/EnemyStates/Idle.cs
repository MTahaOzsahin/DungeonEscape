using DungeonEscape.Abstracts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Concrates.StateMachines.EnemyStates
{
    public class Idle : IStates
    {
        IMover _mover;
        IMyAnimation _animation;

        float maxStandTime;
        float currentStandTime = 0f;


        public bool IsIdle { get;private set; }
        public Idle(IMover mover,IMyAnimation animation)
        {
            _mover = mover;
            _animation = animation;
        }
        public void OnEnter()
        {
            IsIdle = true;
            _animation.MoveAnimation(0f);
            maxStandTime = Random.Range(4f, 10f);
        }

        public void OnExit()
        {
            currentStandTime = 0f;
        }

        public void Tick()
        {
            _mover.Movement(new Vector2(0f,0f));

            currentStandTime += Time.deltaTime;

            if (currentStandTime > maxStandTime)
            {
                IsIdle = false;
            }
        }
    }
}
