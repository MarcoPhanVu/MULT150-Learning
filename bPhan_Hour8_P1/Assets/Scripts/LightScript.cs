using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject light;
    void Start()
    {
        light = GameObject.Find("LightBulb");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            light.GetComponent<Light>().enabled = !light.GetComponent<Light>().enabled;
        }
    }
}
