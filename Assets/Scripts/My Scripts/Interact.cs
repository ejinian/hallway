using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Interact : MonoBehaviour {

    public string interactButton;
    public float interactDistance = 3f;
    public LayerMask interactLayer;

    public Image interactIcon;
    public bool isInteracting;
	void Start ()
    {
        if (interactIcon != null)
        {
            interactIcon.enabled = false;
        }
	}
	
	void Update ()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, interactDistance))
        {
            if (isInteracting == false)
            {
                if (interactIcon != null)
                {
                    interactIcon.enabled = true;
                }
                if (Input.GetButtonDown(interactButton))
                {
                    if (hit.collider.CompareTag("Door1"))
                    {
                        hit.collider.GetComponent<Door>().ChangeDoorState();
                    }
                    else if (hit.collider.CompareTag("Key"))
                    {
                        hit.collider.GetComponent<Key>().UnlockDoor();
                    }
                    else if (hit.collider.CompareTag("Door2"))
                    {
                        hit.collider.GetComponent<Door2>().ChangeDoorState();
                    }
                    else if (hit.collider.CompareTag("Note"))
                    {
                        hit.collider.GetComponent<Note>().ShowNoteImage();
                    }
                }
            }
        }
	}
}
