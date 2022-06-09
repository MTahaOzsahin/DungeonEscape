using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Concrates.Animations
{
    public class AnimationImpactsWatcher : MonoBehaviour
    {
        public event System.Action OnImpact;
        public void Impact()
        {
            OnImpact?.Invoke();
        }
    }
}
