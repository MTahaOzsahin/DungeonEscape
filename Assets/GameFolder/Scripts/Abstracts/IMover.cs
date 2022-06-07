using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Abstracts
{
    public interface IMover 
    {
        public void Tick(float horizontal); //enemyde kullan�lmal� ihtimali i�in olu�turldu.
    }
}
