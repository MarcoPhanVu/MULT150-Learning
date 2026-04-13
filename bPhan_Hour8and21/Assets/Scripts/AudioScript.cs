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
            Debug.Log("Z pressed, toggle audio");
            ToggleAudio();
        }
    }

    void ToggleAudio()
    {
        audioSource.Play();
    }
}
