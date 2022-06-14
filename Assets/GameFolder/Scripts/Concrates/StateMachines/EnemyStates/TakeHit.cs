using DungeonEscape.Abstracts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Concrates.StateMachines.EnemyStates
{
    public class TakeHit : IStates
    {
        IMyAnimation _myAnimation;

        float maxDelayTime = 0.2f;
        float currentDelayTime = 0f;
        public bool IsTakeHit { get;private set; }
        public TakeHit(IHealth health,IMyAnimation myAnimation)
        {
            _myAnimation = myAnimation;
            health.OnHealthChange += (currentHealth,maxHealth) => OnEnter();
        }
        public void OnEnter()
        {
            IsTakeHit = true;
        }

        public void OnExit()
        {
            currentDelayTime = 0f;
        }

        public void Tick()
        {
            currentDelayTime += Time.deltaTime;
            if (currentDelayTime > maxDelayTime && IsTakeHit)
            {
                _myAnimation.TakeHitAnimation();
                IsTakeHit = false;
            }
        }
    }
}

