using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDamage : MonoBehaviour
{

    public bool isEnabled = true;

    [Tooltip("Ѕезопасное врем€ нахождени€ в воде в секундах")]
    public float timerStart = 2;
    [SerializeField]
    private float timer;

    private void Start()
    {
        timer = timerStart;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && isEnabled)
        {
            if (timer <= 0)
            {
                timer = timerStart;
                PlayerController.Die();
            }

            timer -= Time.deltaTime;
        }
    }

}
