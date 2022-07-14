using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private int Bol = 0;
    public GameObject target;

    public AudioSource Sound;
    public AudioClip Day, Night;

    private int num = 36;
    private void Start()
    {
      //noth
    }
    
    void Update()
    {





        transform.RotateAround(target.transform.position, Vector3.right, num * Time.deltaTime);
        transform.RotateAround(target.transform.position, Vector3.up, num * Time.deltaTime);
        
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
