using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurfaceAudio : MonoBehaviour
{
    public FirstPersonAudio firstPersonAudio;

    [Header("Audio")]
    public AudioSource stepsMetal;
    public AudioSource defaultStep;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, -transform.up, out hit, 2))
        {
            if (hit.collider.tag == "SurfaceMetal")
            {
                firstPersonAudio.stepAudio = stepsMetal;
            } else
            {
                firstPersonAudio.stepAudio = defaultStep;
            }
        }
    }
}
