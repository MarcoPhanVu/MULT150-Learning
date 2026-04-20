using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCalculator : MonoBehaviour
{
    // Start is called before the first frame update
    int bounceCount = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter (Collision collider)
    {
        print(collider.gameObject.name + " has collided the " + gameObject.name);
        bounceCount++;
        print("Bounce count: " + bounceCount);
    }
    void OnCollisionStay (Collision collider)
    {
        // print(collider.gameObject.name + " is still in the " + gameObject.name);
    }

    void OnCollisionExit (Collision collider)
    {
        // print(collider.gameObject.name + " has left the " + gameObject.name);
    }
}
