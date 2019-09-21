using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class click : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject model;
    public GameObject vb;
    public AudioSource audio;
    public bool toggle = false;

    // Start is called before the first frame update
    void Start()
    {
        vb.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        model.SetActive(false);
        audio.Stop();           // Wait until ready to play
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (!toggle )
        {
            model.SetActive(true);  // Model appears
            audio.Play();           // Play audio
            toggle = true;
        }
        else
        {
            model.SetActive(false);  // Model appears
            audio.Stop();           // Play audio
            toggle = false;
        }

    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
    }
}
