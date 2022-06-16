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
        System.Action _deadCallBack;
        float currentTime = 0f;
        public Dead(IEntityController entityController,IMyAnimation myAnimation,System.Action deadCallBack)
        {
            _entityController = entityController;
            _myAnimation = myAnimation;
            _deadCallBack = deadCallBack;
        }
        public void OnEnter()
        {
            _myAnimation.DeadAnimation();
            _deadCallBack?.Invoke();
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

