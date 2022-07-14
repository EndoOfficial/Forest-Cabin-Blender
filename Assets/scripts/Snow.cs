using UnityEngine;
using System.Collections;



public class Snow : MonoBehaviour
{
    GameObject SnowOb;
    private int Bol = 0;
    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - 0, 5, 100, 30), "Snow"))
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
        SnowOb = GameObject.Find("Snow");
        Disable();
    }

    void Enable()
    {
        SnowOb.GetComponent<Renderer>().enabled = true;
        Bol = 0;
    }
    void Disable()
    {
        SnowOb.GetComponent<Renderer>().enabled = false;
        Bol = 1;
    }
}