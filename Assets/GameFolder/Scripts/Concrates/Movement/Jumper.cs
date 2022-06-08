using DungeonEscape.Abstracts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonEscape.Concrates.Movement
{
    public class Jumper :IJumper
    {
        Rigidbody2D rigidbody2D;

        float jumpForce=150f;
        public Jumper(Rigidbody2D rigidbody)
        {
            rigidbody2D = rigidbody;
        }

        public void Jump()
        {
            rigidbody2D.velocity = Vector2.zero;
            rigidbody2D.AddForce(jumpForce * Time.fixedDeltaTime * Vector2.up * 100f);
            rigidbody2D.velocity = Vector2.zero;
        }
    }
}
