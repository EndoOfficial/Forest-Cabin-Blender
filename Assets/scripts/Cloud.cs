using UnityEngine;
using System.Collections;



public class Cloud : MonoBehaviour
{
    
    GameObject CloudOb;
    AudioSource audioSource;

    private int Bol = 0;
    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - 100, 5, 100, 30), "Clouds"))
        {
            if(Bol == 1)
            {
                Enable();
            }

            else if (Bol == 0)
            {
                Disable();
            }

        }
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        CloudOb = GameObject.Find("Cloud");
        Disable();
    }
 
    void Enable()
    {
        audioSource.mute = !audioSource.mute;
        CloudOb.GetComponent<Renderer>().enabled = true;
        Bol = 0;
    }
    void Disable()
    {
        audioSource.mute = !audioSource.mute;
        CloudOb.GetComponent<Renderer>().enabled = false;
        Bol = 1;
    }
}