using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayAnimation : MonoBehaviour
{
 public GameObject Collider;
 public Animator Object;
 public GameObject Object1;
    void Start()
    {
        Object.GetComponent<Animator>().SetTrigger ("expectation");
        Collider.SetActive(true);
    }

    void OnTriggerEnter(Collider other)
    {
        Object.GetComponent<Animator>().SetTrigger ("Play");
    }

    void OnTriggerExit(Collider other)
    {
        Collider.SetActive(false);
    }
}
