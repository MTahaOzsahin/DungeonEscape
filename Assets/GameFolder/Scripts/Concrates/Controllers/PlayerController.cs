using DungeonEscape.Abstracts;
using DungeonEscape.Concrates.Animations;
using DungeonEscape.Concrates.Movement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

namespace DungeonEscape.Concrates.Controllers
{
    public class PlayerController : MonoBehaviour , IEntityController
    {
        IMyAnimation myAnimation;
        IFlip flip;
        InputsControllers inputControllers;

        [SerializeField] float  moveSpeed;
        [SerializeField] float jumpForce;

        private void Awake()
        {
            inputControllers = new InputsControllers();
            myAnimation = new CharacterAnimations(GetComponent<Animator>());
            flip = new Flip(this);
        }

        private void OnEnable()
        {
            inputControllers.Enable();
            inputControllers.Land.Jump.started += jump;
            inputControllers.Land.DoubleJump.performed += DoubleJump;
        }

        private void OnDisable()
        {
            inputControllers.Disable();
            inputControllers.Land.Jump.started -= jump;
            inputControllers.Land.DoubleJump.performed -= DoubleJump;
        }

        private void Update()
        {
            MovementAndFlip();
            Animations();
        }

        void MovementAndFlip()
        {
            Vector2 direction = inputControllers.Land.Movement.ReadValue<Vector2>();
            flip.FlipCharacter(direction.x);
            transform.Translate(moveSpeed * Time.deltaTime * direction);
        }

        void jump(InputAction.CallbackContext context)
        {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(jumpForce * Time.fixedDeltaTime * Vector2.up * 100f);
        }
        void DoubleJump(InputAction.CallbackContext context)
        {
            this.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(jumpForce * Time.fixedDeltaTime * Vector2.up * 100f);
        }

        void Animations()
        {
            Vector2 moveSpeed = inputControllers.Land.Movement.ReadValue<Vector2>();
            myAnimation.MoveAnimation(moveSpeed.x);
        }
    }
}


