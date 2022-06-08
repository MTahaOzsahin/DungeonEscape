using DungeonEscape.Abstracts;
using DungeonEscape.Concrates.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Concrates.Movement
{
    public class Mover : IMover
    {
        PlayerController playerController;

        float moveSpeed=5f;
        public Mover(PlayerController player)
        {
            playerController = player;
        }

        public void Movement(Vector2 direction)
        {
            playerController.transform.Translate(moveSpeed * Time.deltaTime * direction);
        }
    }
}
