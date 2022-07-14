using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMoon : MonoBehaviour
{

    public GameObject target;

    public int num = 3;
    void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.right, num * Time.deltaTime);
        transform.RotateAround(target.transform.position, Vector3.up, num * Time.deltaTime);
    }
}
