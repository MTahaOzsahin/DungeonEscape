using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Abstracts
{
    public interface IStates 
    {
        void Tick();
        void OnEnter();
        void OnExit();

    }
}
