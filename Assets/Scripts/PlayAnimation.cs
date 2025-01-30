using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayAnimation : MonoBehaviour
{
 public GameObject Collider;
 public Animator Object;
    void Start()
    {
        Collider.SetActive(true);
    }

    void OnTriggerEnter(Collider other)
    {
     if(other.tag=="Play")
        Object.GetComponent<Animator>().SetTrigger ("Play");
    }

    void OnTriggerExit(Collider other)
    {
        Collider.SetActive(false);
    }
}
