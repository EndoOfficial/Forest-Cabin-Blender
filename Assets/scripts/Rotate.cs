using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour
{
    private int Bol = 0;
    public GameObject target;

    public AudioSource Sound;
    public AudioClip Day, Night;

    public Slider Speed;
    public float NewSpeed;


    void Update()
    {
        NewSpeed = Speed.value * 2;

        transform.RotateAround(target.transform.position, Vector3.right, NewSpeed * Time.deltaTime);
        transform.RotateAround(target.transform.position, Vector3.up, NewSpeed * Time.deltaTime);
        
        if ((Bol == 1) && transform.position.y > 26)
        {
            Enable();
            
        }
        if ((Bol == 0) && transform.position.y < 26)
        {
            
            Disable();
        }
    }
    void Enable()
    {
        Sound.clip = Day;
        Sound.Play();
        Bol = 0;
    }

    void Disable()
    {
        Sound.clip = Night;
        Sound.Play();
        Bol = 1;
    }
}
