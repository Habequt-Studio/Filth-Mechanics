using UnityEngine;
using TMPro;
public class Avtomat1 : MonoBehaviour {

    [Header("Ammo")]
    public int CurrentAmmo = 30;
    public int MaxAmmo = 60;
    public int magazineAmmo = 15; //max ammo in magazine

    [Header("Bullet settings")]
    public Transform bullet;
    public int BulletForce = 5000;
    public Transform spawn;

    [Header("Sounds")]
    public AudioClip Fire;
    public AudioClip Reload;

    [Header("Objects")]
    public TMP_Text Ammo_text;
    public GameObject Avtomat;

    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0) && CurrentAmmo > 0)
        {
            LayerMask layerMask = LayerMask.GetMask("Enemy");
            Avtomat.GetComponent<Animator>().SetTrigger("Shot");

            RaycastHit hit;
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask) 
                && hit.collider.CompareTag("Enemy"))

            {
                Enemy en = hit.collider.GetComponent<Enemy>();
                if (en == null)
                {
                    DamageEnemy den = hit.collider.GetComponent<DamageEnemy>();
                    if (den == null)
                    {
                        Debug.LogError("Enemy does not have a valid Enemy scipt!");
                    } else
                    {
                        den.TakeDamage(5);
                    }
                } else
                {
                    en.TakeDamage(5);
                }
            }

            CurrentAmmo--;
            GetComponent<AudioSource>().PlayOneShot(Fire);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<AudioSource>().PlayOneShot(Reload);
            Avtomat.GetComponent<Animator>().SetTrigger("Reloaded");
            int deltaAmmo = magazineAmmo - CurrentAmmo;
            MaxAmmo -= deltaAmmo;
            CurrentAmmo = Mathf.Min(magazineAmmo, MaxAmmo);
        }

        Ammo_text.text = "Ammo: " + CurrentAmmo.ToString() + "/" + MaxAmmo.ToString();
    }
}
