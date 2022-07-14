using UnityEngine;
using System.Collections;



public class Fire : MonoBehaviour
{
    GameObject FireOb;
    AudioSource audioSource;

    private int Bol = 0;
    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - 300, 5, 100, 30), "Fire"))
        {
            if (Bol == 1)
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
        FireOb = GameObject.Find("Smoke");
        Disable();
    }

    void Enable()
    {
        FireOb.GetComponent<Renderer>().enabled = true;
        audioSource.mute = !audioSource.mute;
        Bol = 0;
    }
    void Disable()
    {
        FireOb.GetComponent<Renderer>().enabled = false;
        audioSource.mute = !audioSource.mute;
        Bol = 1;
    }
}