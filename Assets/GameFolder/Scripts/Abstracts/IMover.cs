using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Abstracts
{
    public interface IMover 
    {
        public void Movement(Vector2 direction); //enemyde kullanýlmalý ihtimali için oluþturldu.
    }
}
