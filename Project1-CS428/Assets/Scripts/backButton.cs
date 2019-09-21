using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using Vuforia;


public class backButton : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject textInfo;     // Displaying title, author, etc.
    public GameObject reviews;      // Object for displaying text & video reviews
    public GameObject vb;           // Virtual Button
    public VideoPlayer videoPlayer;       // Video Source
    public bool toggle = false;     // Toggle for button

    // Start is called before the first frame update
    void Start()
    {
        vb.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        reviews.SetActive(false);   // On init, text/video reviews are not shown
        videoPlayer.Stop();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (!toggle)
        {
            reviews.SetActive(true);    // Show text/video reviews object
            textInfo.SetActive(false);  // Hide text
            videoPlayer.Play();         // Play video when we toggle on
            toggle = true;
        }
        else
        {
            reviews.SetActive(false);  // Hide text/video reviews object
            textInfo.SetActive(true);  // Show text
            videoPlayer.Stop();        // Stop video when not showing
            toggle = false;
        }
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
    }
}