using UnityEngine;
using System.Collections;

public class EnemySmash : MonoBehaviour{
public GameObject Emeny;
public GameObject DeadZone;
   void Start() {
    DeadZone.SetActive (false);
   }
   void OnTriggerEnter(Collider other) {
    if(other.tag=="Player") {
        Emeny.GetComponent<Animator>().SetTrigger ("Attack");
        DeadZone.SetActive (true);
    }
   }
  void OnTriggerExit(Collider other) {
   if(other.tag=="Player") {
    DeadZone.SetActive (false);
   }
  }}