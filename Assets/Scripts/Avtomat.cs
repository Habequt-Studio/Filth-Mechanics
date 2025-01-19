using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Avtomat1 : MonoBehaviour {

  public Transform bullet;
  public int BulletForce = 5000;
  public int CurrentAmmo = 30;
  public AudioClip Fire;
  public AudioClip Reload;
  public Transform spawn;
  public TMP_Text Ammo_text;
  public int MaxAmmo = 21;
  public GameObject Avtomat;

  void Update () {
    if (Input.GetMouseButtonDown (0) && CurrentAmmo > 0) {
    Avtomat.GetComponent<Animator>(). SetTrigger ("Shot");
      Transform BulletInstance = (Transform)Instantiate (bullet, spawn.position, Quaternion.identity);
      BulletInstance.GetComponent<Rigidbody> ().AddForce (transform.forward * (BulletForce * -1));
      CurrentAmmo = CurrentAmmo - 1;
      GetComponent<AudioSource> ().PlayOneShot (Fire);
    }
    if (Input.GetKeyDown (KeyCode.R)) {
    GetComponent<AudioSource> ().PlayOneShot (Reload);
    Avtomat.GetComponent<Animator>(). SetTrigger ("Reloaded");
      MaxAmmo = MaxAmmo - 15;
      CurrentAmmo = 15;
    }
    Ammo_text.text="Ammo: "+CurrentAmmo.ToString()+"/"+MaxAmmo.ToString();
}
}