using UnityEngine;
using System.Collections;

public class DamageEnemy : MonoBehaviour {
public GameObject Emeny;
public GameObject Ragdoll;
public float HP = 100;
void Update () {
 if (HP < 0) {
  Instantiate(Ragdoll, transform.position, transform.rotation);
  Destroy (gameObject);
    void OnTriggerEnter (Collider other) {
     if(other.tag=="ControllerBullet") {
      HP = HP - 15f;
    }}
}}}