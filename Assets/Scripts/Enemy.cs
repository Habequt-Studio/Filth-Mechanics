using System.Collections;
using System.Data.Common;
using Unity.VisualScripting;
using UnityEditor.UI;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float projectileSpeed = 1.0f;
    public Transform pointOfFire;

    [Tooltip("Instance of the projectile")]
    [SerializeField] private GameObject projectile;

    private void Start()
    {
        StartCoroutine(spawnProjectiles());
    }

    IEnumerator spawnProjectiles()
    {
        while(true)
        {
            GameObject instance = Instantiate(projectile, pointOfFire.position, Quaternion.identity);
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.linearVelocity = projectileSpeed * pointOfFire.forward;
            Destroy(instance, 5);
            yield return new WaitForSeconds(1f);
        }
    }
}
