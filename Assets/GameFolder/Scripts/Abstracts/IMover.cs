using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Abstracts
{
    public interface IMover 
    {
        public void Movement(Vector2 direction); //enemyde kullan�lmal� ihtimali i�in olu�turldu.
    }
}
