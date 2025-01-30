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
        Object = GetComponent<Animator>();
    }

    void OnTriggerExit(Collider other)
    {
        Collider.SetActive(false);
    }
}
