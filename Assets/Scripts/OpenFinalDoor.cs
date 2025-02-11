using UnityEngine;
using System.Collections;

public class OpenFinalDoor : MonoBehaviour
{
 public GameObject ColliderOpen;
 public GameObject ColliderClose;
 public Transform Door;
    void Start()
    {
        ColliderClose.SetActive (true);
        ColliderOpen.SetActive (true);
        Door.GetComponent<Animator>().SetTrigger ("Idle");
    }

    void OnTriggerEnter()
    {
       Door.GetComponent<Animator>().SetTrigger ("Open");
    }
    void OnTriggerExit()
    {
        Door.GetComponent<Animator>().SetTrigger ("Close");
    }
}