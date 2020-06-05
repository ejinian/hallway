using UnityEngine;
using System.Collections;

public class ChangeAmbienceTrigger : MonoBehaviour {
    
    public AudioClip hallway;
    private ChangeAmbience theAM;
	void Start ()
    {
        theAM = FindObjectOfType<ChangeAmbience>();
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (hallway != null)
            {
                theAM.ChangeMusic(hallway);
            }
        }
    }

    void Update ()
    {

	}
}
