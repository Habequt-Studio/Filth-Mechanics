using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Avtomat : MonoBehaviour {

  public Transform bullet;
  public int BulletForce = 5000;
  public int Magaz = 30;
  public AudioClip Fire;
  public AudioClip Reload;  
  public Transform spawn;
  public text Ammo;
 public int Arsenal = 21;
 public text UIArsenal;
  void Update () {
    if (Input.GetMouseButtonDown (0) && Magaz > 0) {
      Transform BulletInstance = (Transform)Instantiate (bullet, spawn.position, Quaternion.identity);
      BulletInstance.GetComponent<Rigidbody> ().AddForce (transform.forward * (BulletForce * -1));
      Magaz = Magaz - 1;
      GetComponent<AudioSource> ().PlayOneShot (Fire);
      GetComponent<AudioSource> ().PlayOneShot (Reload);

    }
    if (Input.GetKeyDown (KeyCode.R)) {
      Arsenal = Arsenal - 7;
      Magaz = 7;
    
    }
    Ammo.text="Ammo  :  "+Magaz;
    UIArsenal.text="/  "+Arsenal;
  }
}