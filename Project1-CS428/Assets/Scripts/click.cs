using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class click : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject model;
    public GameObject vb;
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        vb.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        model.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        model.SetActive(true);
        audio.Play();
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        audio.Stop();
    }
}
