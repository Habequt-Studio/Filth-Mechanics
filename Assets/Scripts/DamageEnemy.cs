using UnityEngine;
using System.Collections;

public class DamageEnemy : MonoBehaviour {
public GameObject Emeny;
public GameObject Ragdoll;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter (Collider other) {
    if(other.tag=="") {
    Emeny.SetActive (false);
    Ragdoll.SetActive (true);
    Instantiate(Ragdoll, transform.position, transform.rotation);
        
    }
    }
}
