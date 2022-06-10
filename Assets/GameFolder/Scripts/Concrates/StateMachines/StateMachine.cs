using DungeonEscape.Abstracts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Concrates.StateMachines
{
    public class StateMachine 
    {
        List<StateTransition> _stateTransitions = new List<StateTransition>();
        List<StateTransition> _anyStateTransitions = new List<StateTransition>();
        IStates _currentState;

        public void SetState(IStates state)
        {
            if (state == _currentState) return;

            _currentState?.OnExit();

            _currentState = state;

            _currentState.OnEnter();
        }

        public void Tick()
        {
            StateTransition stateTransition = CheckForTransition();

            if (stateTransition != null)
            {
                SetState(stateTransition.To);
            }

            _currentState.Tick();
        }

        StateTransition CheckForTransition()
        {
            foreach (StateTransition anyStateTransition in _anyStateTransitions)
            {
                if (anyStateTransition.Conditions.Invoke()) return anyStateTransition;
            }
            foreach (StateTransition stateTransition  in _stateTransitions)
            {
                if (stateTransition.Conditions() && stateTransition.From == _currentState)
                {
                    return stateTransition;
                }
            }

            return null;
        }

        public void AddTransition(IStates from, IStates to,System.Func<bool> condition)
        {
            StateTransition stateTransition = new StateTransition(from, to, condition);
            _stateTransitions.Add(stateTransition);
        }

        public void AddAnyState(IStates to,System.Func<bool> condition)
        {
            StateTransition anyStateTransition = new StateTransition(null, to, condition);
            _anyStateTransitions.Add(anyStateTransition);
        }
    }
}
