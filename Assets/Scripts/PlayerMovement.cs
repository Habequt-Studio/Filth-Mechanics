using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    [Header("Stamina")]
    [SerializeField] private Slider sliderStamina;
    [SerializeField] private Text currentStaminatext;
    [SerializeField] private float currentStamina;
    [SerializeField] private float maxStamina;
    [SerializeField] private float minStamina;

    //[Space(10)]
    //public CharacterController controller;

    //private readonly float SpawnSpeed = 5f;
    //public float speed;
    //public float gravity = -9.81f;
    //public float jumpHeight = 3f;

    //public Transform groundCheck;
    //public float groundDistance = 0.4f;
    //public LayerMask groundmask;

    //Vector3 velocity;
    //bool isGrounded;

    private void Start()
    {
        sliderStamina.value = 0;
        sliderStamina.maxValue = maxStamina;
        sliderStamina.minValue = minStamina;
    }

    void Update()
    {
        //isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundmask);

        //if (isGrounded && velocity.y < 0)
        //{
        //    velocity.y = -2f;
        //}

        //float x = Input.GetAxis("Horizontal");
        //float z = Input.GetAxis("Vertical");

        //Vector3 move = transform.right * x + transform.forward * z;

        //controller.Move(speed * Time.deltaTime * move);

        //if (Input.GetButtonDown("Jump") && isGrounded)
        //{
        //    velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        //}

        //velocity.y += gravity * Time.deltaTime;

        //controller.Move(velocity * Time.deltaTime);

        if (currentStamina < maxStamina)
        {
            currentStamina += Time.deltaTime;
            if (currentStamina > maxStamina)
            {
                //currentStamina = maxStamina;
                currentStamina = minStamina; //DEBUG
            }
            sliderStamina.value = currentStamina;
            print("Current stamina: " + currentStamina.ToString());
        }
    }

}