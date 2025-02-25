using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private Slider sliderStamina;
    [SerializeField] private Text currentStaminatext;

    [Space(10)]
    [SerializeField] private float currentStamina;
    [SerializeField] private float maxStamina;
    [SerializeField] private float minStamina;


    public CharacterController controller;


    private float SpawnSpeed = 5f;
    public float speed;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundmask;

    Vector3 velocity;
    bool isGrounded;

    void Start()
    {
        if (currentStamina == 0)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                speed = SpawnSpeed;
            }
        }

        sliderStamina.maxValue = maxStamina;
        sliderStamina.minValue = minStamina;

        currentStamina = maxStamina;
    }
    // Update is called once per frame
    void Update()
    {


        sliderStamina.value = currentStamina;
        currentStaminatext.GetComponent<Text>().text = string.Format("{0:0}", currentStamina);

        StaminaCheked();
        StaminaKeys();

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundmask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }

    private void StaminaCheked()
    {
        if (currentStamina <= minStamina)
            currentStamina = minStamina;

        if (currentStamina >= maxStamina)
            currentStamina = maxStamina;
        if (currentStamina == minStamina)
            speed = SpawnSpeed;

    }

    private void StaminaKeys()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                speed = 15f;
                currentStamina -= Time.deltaTime * 3f;
            }
        }
            if (Input.GetKey(KeyCode.LeftShift)==false)
        {
            speed = SpawnSpeed;
            currentStamina += Time.deltaTime / 1f;
        }
    }
}