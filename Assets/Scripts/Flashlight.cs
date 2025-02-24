using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flashlight : MonoBehaviour
{
    [SerializeField] private GameObject spotlight;
    [SerializeField] private Image barLight;
    public float batteryLife = 100.0f; // Общая емкость аккумулятора
    public float drainRate = 10.0f;    // Скорость разрядки аккумулятора
    private bool isFlashlightOn = false;

    public bool grabActive = false;
    void Update()
    {
        // Переключение фонарика при нажатии кнопки "F" или кнопки на экране
        if (Input.GetKeyDown(KeyCode.F) && grabActive)
        {
            isFlashlightOn = !isFlashlightOn;
        }

        // Обновление состояния аккумулятора
        if (isFlashlightOn)
        {
            if (batteryLife > 0)
            {
                batteryLife -= (drainRate/2) * Time.deltaTime;
            }
            else
            {
                batteryLife = 0;
                isFlashlightOn = false;
            }
        }
        else
        {
            if (batteryLife < 100)
            {
                batteryLife += drainRate * Time.deltaTime; // Зарядка медленнее, когда фонарик выключен
            }
            else
            {
                batteryLife = 100;
            }
        }
        //Зарядка
        barLight.fillAmount = batteryLife / 100;
        
        // Применение состояния фонарика (включен/выключен)
        if (isFlashlightOn)
        {
            spotlight.SetActive(true);
        }
        else
        {
            spotlight.SetActive(false);
        }
    }
}
