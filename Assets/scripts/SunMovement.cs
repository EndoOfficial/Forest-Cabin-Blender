using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SunMovement : MonoBehaviour
{
    public Slider TimeSetter;
    public float TimeSpeed;

    public Light Sun;
    public float SunRotation;
    void Start()
    {
        SunRotation = Sun.GetComponent<Transform>().rotation.x;
    }

    // Update is called once per frame
    void Update()
    {
        TimeSpeed = TimeSetter.value / 10;
        Sun.transform.Rotate(TimeSpeed, 0, 0, Space.World);

        SunRotation = TimeSpeed;
    }
}
