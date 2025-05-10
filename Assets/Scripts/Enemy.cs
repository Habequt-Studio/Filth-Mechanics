using System.Collections;
using System.Data.Common;
using Unity.VisualScripting;
using UnityEditor.UI;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float projectileSpeed = 1.0f;
    public Transform pointOfFire;

    [SerializeField] private int maxHealth = 20;
    [SerializeField] private int health;

    [Tooltip("Instance of the projectile")]
    [SerializeField] private GameObject projectile;

    [SerializeField] private GameObject ragdoll;

    private void Start()
    {
        health = maxHealth;
        StartCoroutine(spawnProjectiles());
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health < 0)
        {
            Debug.Log("Enemy died!");
            Destroy(this.gameObject);
            Instantiate(ragdoll, transform.position, Quaternion.identity);
        }
        else
        {
            Debug.Log("Enemy taken " + damage.ToString() + " damage");
        }
    }

    IEnumerator spawnProjectiles()
    {
        while(true)
        {
            GameObject instance = Instantiate(projectile, pointOfFire.position, Quaternion.identity);
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.linearVelocity = projectileSpeed * pointOfFire.forward;
            Destroy(instance, 5);
            yield return new WaitForSeconds(3.4f);
        }
    }
}
