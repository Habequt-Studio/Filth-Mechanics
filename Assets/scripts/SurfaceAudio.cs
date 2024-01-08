using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SurfaceAudio : MonoBehaviour
{
    public FirstPersonAudio firstPersonAudio;

    [Header("Default")]
    public AudioClip[] defaultSteps;
    public AudioClip[] defaultLanding;
    public AudioClip[] defaultJump;

    [Header("Metal")]
    public AudioClip[] metalSteps;
    public AudioClip[] metalLanding;
    public AudioClip[] metalJump;

    [Header("Water")]
    public AudioClip[] waterSteps;
    public AudioClip[] waterLanding;
    public AudioClip[] waterJump;

    [Header("Stone")]
    public AudioClip[] stoneSteps;
    public AudioClip[] stoneLanding;
    public AudioClip[] stoneJump;

    private Jump jump;

    private void Start()
    {
        jump = GetComponent<Jump>();
    }

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, -transform.up, out hit, 2))
        {
            if (hit.collider.tag == "SurfaceMetal")
            {
                firstPersonAudio.stepAudio.clip = metalSteps[Random.Range(0, metalSteps.Length)];
                firstPersonAudio.landingSFX = metalLanding;
                firstPersonAudio.jumpSFX = metalJump;
            } else if (hit.collider.tag == "SurfaceWater")
            {
                firstPersonAudio.stepAudio.clip = waterSteps[Random.Range(0, waterSteps.Length)];
                firstPersonAudio.landingSFX = waterLanding;
                firstPersonAudio.jumpSFX = waterJump;
            } else if (hit.collider.tag == "SurfaceStone")
            {
                firstPersonAudio.stepAudio.clip = stoneSteps[Random.Range(0, stoneSteps.Length)];
                firstPersonAudio.landingSFX = stoneLanding;
                firstPersonAudio.jumpSFX = stoneJump;
            }
            else
            {
                firstPersonAudio.stepAudio.clip = defaultSteps[Random.Range(0, defaultSteps.Length)];
                firstPersonAudio.landingSFX = defaultLanding;
                firstPersonAudio.jumpSFX = defaultJump;
            }
        }
    }
}
