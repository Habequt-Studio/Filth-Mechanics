using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private int health;
    private int maxHealth = 20;

    private void Start()
    {
        health = maxHealth;
    }

    private void Update()
    {
        if (health <= 0)
        {
            Die();
        }
    }

    public static void Die()
    {
        print("Player died");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //reload scene
    }
}
