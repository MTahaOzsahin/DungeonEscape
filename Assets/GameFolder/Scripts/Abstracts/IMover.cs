using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Abstracts
{
    public interface IMover 
    {
        public void Tick(float horizontal); //enemyde kullanýlmalý ihtimali için oluþturldu.
    }
}
