using UnityEngine;
using System.Collections;



public class Fireflies : MonoBehaviour
{
    GameObject FlyOb;
    private int Bol = 0;
    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - 200, 5, 100, 30), "Flies"))
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
        FlyOb = GameObject.Find("Firefly");
        Disable();
    }

    void Enable()
    {
        FlyOb.GetComponent<Renderer>().enabled = true;
        Bol = 0;
    }
    void Disable()
    {
        FlyOb.GetComponent<Renderer>().enabled = false;
        Bol = 1;
    }
}

