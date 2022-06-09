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
        IFliper fliper;
        IMover mover;
        IOnGroundChecker onGroundChecker;
        IJumper jumper;
        InputsControllers inputControllers;

        float timer = 0f;

        private void Awake()
        {
            inputControllers = new InputsControllers();
            myAnimation = new CharacterAnimations(GetComponent<Animator>());
            mover = new Mover(this);
            fliper = new Fliper(this);
            jumper = new Jumper(GetComponent<Rigidbody2D>());
            onGroundChecker = GetComponent<IOnGroundChecker>();
        }

        private void OnEnable()
        {
            inputControllers.Enable();
            inputControllers.Land.Jump.started += jump;
            inputControllers.Land.DoubleJump.performed += jump;
            inputControllers.Land.Attack.performed += AttackAnimations;
            inputControllers.Land.PowerAttack.performed += PowerAttackAnimations;
        }

        private void OnDisable()
        {
            inputControllers.Disable();
            inputControllers.Land.Jump.started -= jump;
            inputControllers.Land.DoubleJump.performed -= jump;
            inputControllers.Land.Attack.performed -= AttackAnimations;
            inputControllers.Land.PowerAttack.performed -= PowerAttackAnimations;
        }

        private void Update()
        {
            FlipAndMovement();
            Animations();
        }

        void FlipAndMovement()
        {
            Vector2 direction = inputControllers.Land.Movement.ReadValue<Vector2>();
            fliper.FlipCharacter(direction.x);
            mover.Movement(direction);
        }

        void jump(InputAction.CallbackContext context)
        {
            if (onGroundChecker.IsGround)
            {
                jumper.Jump();
                timer += Time.deltaTime;
            }
            if (context.performed && timer != 0f)
            {
                jumper.Jump();
                timer = 0f;
            }
        }
       

        void Animations()
        {
            Vector2 moveSpeed = inputControllers.Land.Movement.ReadValue<Vector2>();
            myAnimation.MoveAnimation(moveSpeed.x);
            myAnimation.JumpingAnimation(!onGroundChecker.IsGround);
        }
        void AttackAnimations(InputAction.CallbackContext context)
        {
            myAnimation.AttackingAnimation();
        }
        void PowerAttackAnimations(InputAction.CallbackContext context)
        {
            myAnimation.PowerAttackingAnimation();
        }
    }
}


