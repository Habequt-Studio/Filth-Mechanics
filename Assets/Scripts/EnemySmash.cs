using UnityEngine;
using System.Collections;

public class EnemySmash : MonoBehaviour{
public GameObject Emeny;
public GameObject DamageForController;
   void Start() {
    DamageForController.SetActive (false);
   }
   void OnTriggerEnter(Collider other) {
    if(other.tag=="Player") {
        Emeny.GetComponent<Animator>().SetTrigger ("Attack");
        DamageForController.SetActive (true);
    }
   }
  void OnTriggerExit(Collider other) {
   if(other.tag=="Player") {
    DamageForController.SetActive (false);
   }
  }}