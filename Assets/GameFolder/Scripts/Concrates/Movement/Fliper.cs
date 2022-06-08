using DungeonEscape.Abstracts;
using DungeonEscape.Concrates.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Concrates.Movement
{
    public class Fliper : IFliper
    {
        IEntityController entityController;
        public Fliper(IEntityController entity)
        {
            entityController = entity;
        }
        public void FlipCharacter(float direction)
        {
            if (direction == 0) return;

            float mathValue = Mathf.Sign(direction);

            if (mathValue != entityController.transform.localScale.x)
            {
                entityController.transform.localScale = new Vector2(mathValue, 1f);
            }
        }
    }
}
