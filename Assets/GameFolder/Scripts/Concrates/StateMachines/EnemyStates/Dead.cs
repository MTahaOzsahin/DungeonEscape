using DungeonEscape.Abstracts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Concrates.StateMachines.EnemyStates
{
    public class Dead : IStates
    {
        IMyAnimation _myAnimation;
        IEntityController _entityController;

        float currentTime = 0f;
        public Dead(IEntityController entityController,IMyAnimation myAnimation)
        {
            _entityController = entityController;
            _myAnimation = myAnimation;
        }
        public void OnEnter()
        {
            _myAnimation.DeadAnimation();
        }

        public void OnExit()
        {
            currentTime = 0f;
        }

        public void Tick()
        {
            currentTime += Time.deltaTime;
            if (currentTime > 3f)
            {
                Object.Destroy(_entityController.transform.gameObject);
            }
        }
    }
}

