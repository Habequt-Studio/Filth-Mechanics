using UnityEngine;
using System.Collections;

public class DamageEnemy : MonoBehaviour {
public GameObject Emeny;
public GameObject Ragdoll;
public float HP = 100;
void Update () {
 if (HP < 0) {
    void OnTriggerEnter (Collider other) {
    if(other.tag=="") {
    Emeny.SetActive (false);
    Ragdoll.SetActive (true);
    Instantiate(Ragdoll, transform.position, transform.rotation);
        
    }
}}

