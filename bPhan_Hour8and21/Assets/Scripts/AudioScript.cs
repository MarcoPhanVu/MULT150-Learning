using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)  || Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Jump"))
        {
            audioSource.Stop();
            Debug.Log("Z pressed, stopping music");
        }
        else if(Input.GetKeyDown(KeyCode.X))
        {
            audioSource.Play(); // Will loop forever every frame.
            Debug.Log("X pressed, Starting music");
        }
    }
}
