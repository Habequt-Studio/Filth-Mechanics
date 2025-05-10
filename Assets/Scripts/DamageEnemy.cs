using UnityEngine;

public class DamageEnemy : MonoBehaviour {

    public GameObject Emeny;
    public GameObject Ragdoll;

    [SerializeField] private int maxHP = 100;
    private int HP;

    private void Start()
    {
        HP = maxHP;
    }

    public void TakeDamage(int damage)
    {
        HP -= damage;
        if (HP < 0)
        {
            Instantiate(Ragdoll, transform.position, transform.rotation);
            Destroy(transform.parent.gameObject);
            Debug.Log("Damage enemy died");
        }
        else
        {
            Debug.Log("Damage enemy has taken " + damage.ToString() + " damage");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ControllerBullet"))
        {
            TakeDamage(15);
        }
    }
}