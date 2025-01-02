using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private int health;
    [SerializeField] private int maxHealth = 20;

    [SerializeField] private Image healthImage;

    //health icons
    [SerializeField] private Sprite HP_full; //full
    [SerializeField] private Sprite HP_lower; //lower
    [SerializeField] private Sprite HP_half; //half
    [SerializeField] private Sprite HP_lowest; //lowest

    private void Start()
    {
        health = maxHealth;
        updateHealth(); //ladno
    }

    public static void Die()
    {
        print("Player died");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //reload scene
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        updateHealth();
    }

    private void updateHealth()
    {
        if (health <= 0)
        {
            Die();
        } else if (health <= maxHealth/4)
        {
            healthImage.sprite = HP_lowest;
        } else if (health <= maxHealth/2)
        {
            healthImage.sprite = HP_half;
        } else if (health <= maxHealth/4*3)
        {
            healthImage.sprite = HP_lower;
        } else //(health >= maxHealth)
        {
            healthImage.sprite = HP_full;
        }
    }
}
