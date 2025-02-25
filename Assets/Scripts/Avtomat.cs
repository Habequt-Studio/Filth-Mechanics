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

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && CurrentAmmo > 0)
        {
            Avtomat.GetComponent<Animator>().SetTrigger("Shot");
            Transform BulletInstance = (Transform)Instantiate(bullet, spawn.position, spawn.rotation);
            BulletInstance.GetComponent<Rigidbody>().AddRelativeForce(transform.forward * (BulletForce * -1));
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
