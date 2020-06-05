using UnityEngine;
using System.Collections;

public class Flashlight : MonoBehaviour {

    // Use this for initialization
    public Light flashLight;
    public AudioSource audioSource;
    public AudioClip soundFlashLightToggle;
    private bool isActive = true;
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (isActive == false)
            {
                flashLight.enabled = true;
                isActive = true;
                audioSource.PlayOneShot(soundFlashLightToggle);
            }
            else if (isActive == true)
            {
                flashLight.enabled = false;
                isActive = false;
                audioSource.PlayOneShot(soundFlashLightToggle);
            }
        }

	}
}
