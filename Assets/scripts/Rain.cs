using UnityEngine;
using System.Collections;



public class Rain : MonoBehaviour
{
    GameObject RainOb;
    GameObject RippleOb;
    private int Bol = 0;
    AudioSource audioSource;

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - 400, 5, 100, 30), "Rain"))
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
        RainOb = GameObject.Find("Rain");
        RippleOb = GameObject.Find("Ripple");
        Disable();
    }

    void Enable()
    {
        audioSource.mute = !audioSource.mute;
        RainOb.GetComponent<Renderer>().enabled = true;
        RippleOb.GetComponent<Renderer>().enabled = true;
        Bol = 0;
    }
    void Disable()
    {
        audioSource.mute = !audioSource.mute;
        RainOb.GetComponent<Renderer>().enabled = false;
        RippleOb.GetComponent<Renderer>().enabled = false;
        Bol = 1;
    }
}
