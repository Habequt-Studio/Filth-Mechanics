using UnityEngine;
using System.Collections;

public class OpenFinalDoor : MonoBehaviour
{
 public GameObject Collider;
 public Transform FinalDoor;
 public GameObject ColliderNot;

    void Start()
    {
        Collider.SetActive (true);
        ColliderNot.SetActive (false);
    }

    void OnTriggerEnter()
    {
        FinalDoor.GetComponent<Animator>();
    }
    void OnTriggerExit()
    {
        Collider.SetActive (false);
        ColliderNot.SetActive (true);
    }
}
