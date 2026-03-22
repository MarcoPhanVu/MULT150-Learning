using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 31; i++) {
            Debug.Log(i);
            if (i == 24) {
                Debug.Log("It's my birthday!");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
