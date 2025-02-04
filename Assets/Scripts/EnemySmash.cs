using UnityEngine;
using System.Collections;

public class EnemySmash : MonoBehaviour{
public GameObject Emeny;
public GameObject DamageForController;
public GameObject DamageForController1;
public GameObject DamageForController2;
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
   if(other.tag=="Player") {
    DamageForController1.SetActive (false);
   }
   if(other.tag=="Player") {
    DamageForController2.SetActive (false);
   }
  }}