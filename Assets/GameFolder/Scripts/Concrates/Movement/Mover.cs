using DungeonEscape.Abstracts;
using DungeonEscape.Concrates.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Concrates.Movement
{
    public class Mover : IMover
    {
        IEntityController _playerController;

        //float moveSpeed=5f;
        float _moveSpeed;
        public Mover(IEntityController controller, float moveSpeed)
        {
            _playerController = controller;
            _moveSpeed = moveSpeed;
        }

        public void Movement(Vector2 direction)
        {
            _playerController.transform.Translate(_moveSpeed * Time.deltaTime * direction);
        }
    }
}
