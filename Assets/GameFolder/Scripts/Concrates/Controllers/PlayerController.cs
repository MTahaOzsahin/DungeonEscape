using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DungeonEscape.Concrates.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        InputsControllers inputControllers;

        [SerializeField] float  moveSpeed;
        [SerializeField] float jumpForce;

        private void Awake()
        {
            inputControllers = new InputsControllers();
        }

        private void OnEnable()
        {
            inputControllers.Enable();
            inputControllers.Land.Jump.started += jump;
        }

        private void OnDisable()
        {
            inputControllers.Disable();
            inputControllers.Land.Jump.started -= jump;
        }

        private void Update()
        {
            Movement();
        }

        void Movement()
        {
            Vector2 direction = inputControllers.Land.Movement.ReadValue<Vector2>();
            transform.Translate(moveSpeed * Time.deltaTime * direction);
        }

        void jump(InputAction.CallbackContext context)
        {
            transform.Translate( jumpForce * Time.deltaTime * Vector2.up);
        }
    }
}


