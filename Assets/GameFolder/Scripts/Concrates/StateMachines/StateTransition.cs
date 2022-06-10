using DungeonEscape.Abstracts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Concrates.StateMachines
{
    public class StateTransition 
    {
        IStates _from;
        IStates _to;
        System.Func<bool> _conditions;

        public IStates From => _from;
        public IStates To => _to;
        public System.Func<bool> Conditions => _conditions; 

        public StateTransition(IStates from,IStates to,System.Func<bool> conditions)
        {
            _from = from;
            _to = to;
            _conditions = conditions;
        }
    }
}
