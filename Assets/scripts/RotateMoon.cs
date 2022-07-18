using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateMoon : MonoBehaviour
{

    public GameObject target;

    public Slider Speed;
    public float NewSpeed;

    
    void Update()
    {
        NewSpeed = Speed.value * 2;
        transform.RotateAround(target.transform.position, Vector3.right, NewSpeed * Time.deltaTime);
        transform.RotateAround(target.transform.position, Vector3.up, NewSpeed * Time.deltaTime);
    }
}
