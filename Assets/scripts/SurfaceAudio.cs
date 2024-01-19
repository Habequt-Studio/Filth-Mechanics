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
    public AudioClip[] defaultRun;

    [Header("Metal")]
    public AudioClip[] metalSteps;
    public AudioClip[] metalLanding;
    public AudioClip[] metalJump;
    public AudioClip[] metalRun;

    [Header("Water")]
    public AudioClip[] waterSteps;
    public AudioClip[] waterLanding;
    public AudioClip[] waterJump;
    public AudioClip[] waterRun;

    [Header("Stone")]
    public AudioClip[] stoneSteps;
    public AudioClip[] stoneLanding;
    public AudioClip[] stoneJump;
    public AudioClip[] stoneRun;

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
                firstPersonAudio.runningAudio.clip = metalRun[Random.Range(0, metalRun.Length)];
            } else if (hit.collider.tag == "SurfaceWater")
            {
                firstPersonAudio.stepAudio.clip = waterSteps[Random.Range(0, waterSteps.Length)];
                firstPersonAudio.landingSFX = waterLanding;
                firstPersonAudio.jumpSFX = waterJump;
                firstPersonAudio.runningAudio.clip = waterRun[Random.Range(0, waterRun.Length)];
            } else if (hit.collider.tag == "SurfaceStone")
            {
                firstPersonAudio.stepAudio.clip = stoneSteps[Random.Range(0, stoneSteps.Length)];
                firstPersonAudio.landingSFX = stoneLanding;
                firstPersonAudio.jumpSFX = stoneJump;
                firstPersonAudio.runningAudio.clip = stoneRun[Random.Range(0, stoneRun.Length)];
            }
            else
            {
                firstPersonAudio.stepAudio.clip = defaultSteps[Random.Range(0, defaultSteps.Length)];
                firstPersonAudio.landingSFX = defaultLanding;
                firstPersonAudio.jumpSFX = defaultJump;
                firstPersonAudio.runningAudio.clip = defaultRun[Random.Range(0, defaultRun.Length)];
            }
        }
    }
}
