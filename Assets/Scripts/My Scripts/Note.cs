using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Note : MonoBehaviour {
    public Image noteImage;
    public AudioClip pickupSound;
    public AudioClip putAwaySound;
    public GameObject playerObject;
	void Start ()
    {
        noteImage.enabled = false;
	}
    public void ShowNoteImage()
    {
        noteImage.enabled = true;
        GetComponent<AudioSource>().PlayOneShot(pickupSound);
        playerObject.GetComponent<FirstPersonController>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void HideNoteImage()
    {
        noteImage.enabled = false;
        GetComponent<AudioSource>().PlayOneShot(putAwaySound);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        playerObject.GetComponent<FirstPersonController>().enabled = true;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && noteImage.enabled == true)
        {
            HideNoteImage();
        }
    }
}
