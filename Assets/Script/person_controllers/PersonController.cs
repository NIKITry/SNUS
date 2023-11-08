using System;
using System.Collections;
using UnityEngine;

namespace Script.person_controllers

{ 
    public class PersonController : MonoBehaviour
    {
        public bool CanMove { get; private set; } = true;
        
        [Header("Functional Options")] 
        [SerializeField] private bool canSprint = true;
        [SerializeField] private bool canJump = true;
        [SerializeField] private bool canCrouch = true;

        [Header("Controls")] 
        [SerializeField] private KeyCode sprintKey = KeyCode.LeftShift;
        [SerializeField] private KeyCode jumpKey = KeyCode.Space;
        [SerializeField] private KeyCode crouchKey = KeyCode.LeftControl;

        [Header("Movement Parameters")] 
        [SerializeField] private float walkSpeed = 3.0f;
        [SerializeField] private float sprintSpeed = 6.0f;
        [SerializeField] private float crouchingSpeed = 1.5f;

        [Header("Look Parameters")]
        [SerializeField, Range(0.1f, 10)] private float lookSpeedX = 2.0f;
        [SerializeField, Range(0.1f, 10)] private float lookSpeedY = 2.0f;
        [SerializeField, Range(1, 180)] private float upperLookLimit = 80.0f;
        [SerializeField, Range(1, 180)] private float lowerLookLimit = 80.0f;

        [Header("JumpingParameters")]
        [SerializeField] private float jumpForce = 8.0f;
        [SerializeField] private float gravity = 30.0f;

        [Header("Crouch Parameters")] 
        [SerializeField] private float crouchHeight = 0.5f;
        [SerializeField] private float standHeight = 2f;
        [SerializeField] private float timeToCrouch = 0.25f;
        [SerializeField] private Vector3 crouchingCenter = new Vector3(0, 0.5f, 0);
        [SerializeField] private Vector3 standingCenter = new Vector3(0, 0, 0);
        [SerializeField] private bool isCrouching;
        [SerializeField] private bool duringCrouchingAnimation;
        
        
        private Camera _playerCamera;
        private CharacterController _characterController;

        private Vector3 _moveDirection;
        private Vector2 _currentInput;

        private float _rotationX;

        void Awake()
        {
            _playerCamera = GetComponentInChildren<Camera>();
            _characterController = GetComponent<CharacterController>();
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        private void FixedUpdate()
        {
            if (CanMove)
            {
                HandleMovementInput();
                HandleMouseLook();

                if (canJump) HandleJump();
                
                if (canCrouch) HandleCrouch();

                ApplyFinalMovements();
            }
        }

        private void HandleMovementInput()
        {
            _currentInput = new Vector2((isCrouching ? crouchingSpeed : IsSprinting ? sprintSpeed : walkSpeed) * Input.GetAxis("Vertical"), walkSpeed * Input.GetAxis("Horizontal"));

            float moveDirectionY = _moveDirection.y;
            _moveDirection = (transform.TransformDirection(Vector3.forward) * _currentInput.x) + (transform.TransformDirection(Vector3.right) * _currentInput.y);
            _moveDirection.y = moveDirectionY;
        }
        
        private void HandleMouseLook()
        {
            _rotationX -= Input.GetAxis("Mouse Y") * lookSpeedY;
            _rotationX = Mathf.Clamp(_rotationX, -upperLookLimit, lowerLookLimit);
            _playerCamera.transform.localRotation = Quaternion.Euler(_rotationX, 0, 0);
            transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeedX, 0);
        }
        
        private void ApplyFinalMovements()
        {
            if (!_characterController.isGrounded) _moveDirection.y -= gravity * Time.deltaTime;
            _characterController.Move(_moveDirection * Time.deltaTime);
        }

        private void HandleJump()
        {
            if (ShouldJump) _moveDirection.y = jumpForce;
        }

        private void HandleCrouch()
        {
            if (ShouldCrouch) StartCoroutine(CrouchStand());
        }

        private IEnumerator CrouchStand()
        {
            if (isCrouching && Physics.Raycast(_playerCamera.transform.position, Vector3.up, 1f)) yield break;
            duringCrouchingAnimation = true;
            var timeElapsed = 0f;
            var targetHeight = isCrouching ? standHeight : crouchHeight;
            var currentHeight = _characterController.height;
            var targetCenter = isCrouching ? standingCenter : crouchingCenter;
            var currentCenter = _characterController.center;
            while (timeElapsed < timeToCrouch)
            {
                _characterController.height = Mathf.Lerp(currentHeight, targetHeight, timeElapsed / timeToCrouch);
                _characterController.center = Vector3.Lerp(currentCenter, targetCenter, timeElapsed / timeToCrouch);
                timeElapsed += Time.deltaTime;
                yield return null;
            }
            _characterController.height = targetHeight;
            _characterController.center = targetCenter;
            
            isCrouching = !isCrouching;
            
            duringCrouchingAnimation = false;
        }
        
        private bool IsSprinting => canSprint && Input.GetKey(sprintKey);
        private bool ShouldJump => Input.GetKeyDown(jumpKey) && _characterController.isGrounded;
        private bool ShouldCrouch => Input.GetKeyDown(crouchKey) && !duringCrouchingAnimation && _characterController.isGrounded;
    }
}
