using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
 [Header("Stamina main parametrs")]
 public float playerStamina = 100.0f;
 [SerializeField] private float maxStamina = 100.0f;
 [SerializeField] private float JumpCost = 20;
 [HideInInspector] public bool HasReGenerated = true;
 [HideInInspector] public bool WeAreSprinting = false;

 [Header("Stamina Regen parametrs")]
 [Range(0, 50)] [SerializeField] private float staminaDrain = 0.5f;
 [Range(0, 50)] [SerializeField] private float staminaRegen = 0.5f;

 [Header("Stamina Speed parametrs")]
 [SerializeField] private int slowedRunSpeed = 4;
 [SerializeField] private int normalRunSpeed = 8;

 [Header("Stamina UI elements")]
 [SerializeField] private Image StaminaProgressUI = null;
 [SerializeField] private CanvasGroup SliderCanvasGroup = null;

 private PlayerController playerController;

 private void Start()
    {
        playerController = GetComponent<PlayerController>();
    }
    private void Update()
    {
     if (!WeAreSprinting)
      if (playerStamina <= maxStamina - 0.01)
      {
       playerStamina += staminaRegen * Time.deltaTime;
       if (playerStamina >= maxStamina)
       {
        HasReGenerated = true;
       }
      }
    }
}
