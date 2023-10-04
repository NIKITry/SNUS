using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float maximumSpeed;

    [SerializeField] private float rotationSpeed;

    [SerializeField] private float jumpSpeed;

    [SerializeField] private float jumpButtonGracePeriod;

    [SerializeField] private float jumpHorizontalSpeed;

    [SerializeField] private Transform cameraTransform;

    [SerializeField] private LayerMask aimColliderLayerMask = new LayerMask();

    [SerializeField] private Transform debugTransform;

    [SerializeField] private Transform pfBulletProjectile;

    [SerializeField] private Transform spawnBulletPosition;

    public float spread;
    public float fireRate;
    public ParticleSystem muzzleParticles;
    public ParticleSystem sparkParticles;


    public int minSparkEmission = 1;
    public int maxSparkEmission = 7;

    [Header("Muzzleflash Light Settings")] public Light muzzleflashLight;
    public float lightDuration = 0.02f;


    private Animator animator;
    private CharacterController characterController;

    private IEnumerator MuzzleFlashLight()
    {
        muzzleflashLight.enabled = true;
        yield return new WaitForSeconds(lightDuration);
        muzzleflashLight.enabled = false;
    }

    private float lastFired = 1f;

    private float ySpeed;
    private float originalStepOffset;
    private float? lastGroundedTime;
    private float? jumpButtonPressedTime;
    private bool isJumping;
    private bool isGrounded;
    private bool allowInvoke = true;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
        originalStepOffset = characterController.stepOffset;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        float inputMagnitude = Mathf.Clamp01(movementDirection.magnitude);

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            inputMagnitude *= 2f;
        }

        if (Input.GetKey(KeyCode.LeftAlt) || Input.GetKey(KeyCode.RightAlt))
        {
            inputMagnitude *= 0.6f;
        }


        if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKey(KeyCode.LeftControl))
        {
            animator.SetLayerWeight(1, Mathf.Lerp(animator.GetLayerWeight(1), 1f, Time.deltaTime * 10f));
        }

        // тут еще нужно создать условие для приветствия в кепке и без
        // (если кепка надета, то правую руку приклаываем)
        // может быть полезно для нахождения в помещении/на улице
        animator.SetBool("IsInHat", true);

        if (Input.GetKeyUp(KeyCode.LeftAlt) || Input.GetKeyUp(KeyCode.LeftControl))
        {
            animator.SetLayerWeight(1, Mathf.Lerp(animator.GetLayerWeight(1), 0f, Time.deltaTime * 80f));
        }

        // целимся и стреляем
        if (Input.GetMouseButton(1))
        {
            animator.SetBool("IsAiming", true);
        }
        else
        {
            animator.SetBool("IsAiming", false);
        }

        if (Input.GetMouseButton(0))
        {
            animator.SetBool("IsShooting", true);
        }
        else
        {
            animator.SetBool("IsShooting", false);
        }


        if (Input.GetMouseButton(1))
        {
            //СТРЕЛЬБА

            Vector3 mouseWorldPosition = Vector3.zero;

            Vector2 screenCenterPoint = new Vector2(Screen.width / 2f, Screen.height / 2f);
            Ray ray = Camera.current.ScreenPointToRay(screenCenterPoint);
            if (Physics.Raycast(ray, out RaycastHit raycastHit, 9999f, aimColliderLayerMask))
            {
                //debugTransform.transform.position = raycastHit.point;
                mouseWorldPosition = raycastHit.point;
            }

            Vector3 worldAimTarget = mouseWorldPosition;
            worldAimTarget.y = transform.position.y;
            Vector3 aimDirection = (mouseWorldPosition - spawnBulletPosition.position).normalized;
            transform.forward = Vector3.Lerp(transform.forward, aimDirection, Time.deltaTime * 20f);


            //Разброс
            float x = Random.Range(-spread, spread);
            float y = Random.Range(-spread, spread);

            if (Input.GetMouseButton(0))
            {
                if (Time.time - lastFired > 1 / fireRate)
                {
                    lastFired = Time.time;
                    Vector3 aimDir = (mouseWorldPosition - spawnBulletPosition.position).normalized +
                                     new Vector3(x, y, 0);
                    Instantiate(pfBulletProjectile, spawnBulletPosition.position,
                        Quaternion.LookRotation(aimDir, Vector3.forward));
                    Instantiate(sparkParticles, spawnBulletPosition.transform.position,
                        spawnBulletPosition.transform.rotation);
                    muzzleParticles.Emit(1);
                    //Light flash start
                    StartCoroutine(MuzzleFlashLight());
                    sparkParticles.Emit(Random.Range(minSparkEmission, maxSparkEmission));
                }
            }
        }


        animator.SetFloat("Input Magnitude", inputMagnitude / 2, 0.05f, Time.deltaTime);

        float speed = inputMagnitude * maximumSpeed;
        movementDirection = Quaternion.AngleAxis(cameraTransform.rotation.eulerAngles.y, Vector3.up) *
                            movementDirection;
        movementDirection.Normalize();

        Vector3 velocity = movementDirection * speed;
        velocity.y = ySpeed;

        characterController.Move(velocity * Time.deltaTime);

        ySpeed += Physics.gravity.y * Time.deltaTime;

        if (characterController.isGrounded)
        {
            lastGroundedTime = Time.time;
        }

        if (Input.GetButtonDown("Jump"))
        {
            jumpButtonPressedTime = Time.time;
        }

        if (Time.time - lastGroundedTime <= jumpButtonGracePeriod)
        {
            characterController.stepOffset = originalStepOffset;
            ySpeed = -0.5f;
            animator.SetBool("IsGrounded", true);
            isGrounded = true;
            animator.SetBool("IsJumping", false);
            isJumping = false;
            animator.SetBool("IsFalling", false);

            if (Time.time - jumpButtonPressedTime <= jumpButtonGracePeriod)
            {
                ySpeed = jumpSpeed;
                animator.SetBool("IsJumping", true);
                isJumping = true;
                jumpButtonPressedTime = null;
                lastGroundedTime = null;
            }
        }
        else
        {
            characterController.stepOffset = 0;
            animator.SetBool("IsGrounded", false);
            isGrounded = false;

            if ((isJumping && ySpeed < 0) || ySpeed < -2)
            {
                animator.SetBool("IsFalling", true);
            }
        }


        if (movementDirection != Vector3.zero)
        {
            animator.SetBool("IsMoving", true);

            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);

            transform.rotation =
                Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
        else
        {
            animator.SetBool("IsMoving", false);
        }

        //if (isGrounded == false)
        //{
        //    Vector3 velocity = movementDirection * inputMagnitude * jumpHorizontalSpeed;
        //    velocity.y = ySpeed;

        //    characterController.Move(velocity * Time.deltaTime);
        //}
    }


    private void OnAnimatorMove()
    {
        if (isGrounded)
        {
            Vector3 velocity = animator.deltaPosition;
            velocity.y = ySpeed * Time.deltaTime;

            characterController.Move(velocity);
        }
    }

    private void OnApplicationFocus(bool focus)
    {
        if (focus)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }


    public GameObject Cam1;
    public GameObject Cam2;


    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //switchDelay -= Time.deltaTime;
            //if (switchDelay <= 0)
            //{
            Cam1.SetActive(!Cam1.activeSelf);
            Cam2.SetActive(!Cam2.activeSelf);

            //    switchDelay = 0.12f;
            //}
        }
    }
}