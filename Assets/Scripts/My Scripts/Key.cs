using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {
    public Door myDoor;
    public AudioClip keyPickUpNoise;
    public AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void UnlockDoor()
    {
        myDoor.isLocked = false;
        audioSource.PlayOneShot(keyPickUpNoise);
        StartCoroutine("WaitForSelfDestruct");
    }
    IEnumerator WaitForSelfDestruct()
    {
        yield return new WaitForSeconds(keyPickUpNoise.length);
        Destroy(gameObject);
    }
}
