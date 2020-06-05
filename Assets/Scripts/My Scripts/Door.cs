using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {
    public bool open = false;
    public bool test = false;
    public float openDoorAngle = 90f;
    public float closedDoorAngle = 0f;
    public float smooth = 2f;
    private AudioSource audioSource;
    public AudioClip openingSound;
    public AudioClip lockedDoorSound;
    public bool isLocked = true;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

	public void ChangeDoorState()
    {
        if (isLocked != true)
        {
            open = !open;
            if (audioSource != null)
            {
                audioSource.PlayOneShot(openingSound);
            }
        }
        else
        {
            PlayLockedDoorSound();
        }
    }

    public void PlayLockedDoorSound()
    {
        audioSource.PlayOneShot(lockedDoorSound);
    }
	
	
	void Update ()
    {
        if (open)
        {
            Quaternion targetRotationOpen = Quaternion.Euler(0, openDoorAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotationOpen, smooth * Time.deltaTime);
        }
        else
        {
            Quaternion targetRotationClosed = Quaternion.Euler(0, closedDoorAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotationClosed, smooth * Time.deltaTime);
        }
        if (test == true)
        {
            ChangeDoorState();
            test = false;
        }
	}
}
