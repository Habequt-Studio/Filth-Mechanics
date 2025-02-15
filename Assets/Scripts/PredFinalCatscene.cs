using UnityEngine;
using System.Collections;

public class PredFinalCatscene : MonoBehaviour
{
 public GameObject ColliderPred;
 public Transform TimeLine;
 public GameObject Cameras;

    void Start()
    {
        ColliderPred.SetActive (true);
        Cameras.SetActive (false);
    }

    void OnTriggerExit()
    {
        Cameras.SetActive (true);
        ColliderPred.SetActive (false);
    }
}
