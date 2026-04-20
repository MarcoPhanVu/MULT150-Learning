using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider other)
    {
<<<<<<< HEAD
<<<<<<< HEAD
        print(other.gameObject.name + " has entered the " + gameObject.name);
    }
    void OnTriggerStay (Collider other)
    {
        print(other.gameObject.name + " is still in the " + gameObject.name);
=======
        print(other.gameObject.name + " has entered the cube");
    }
    void OnTriggerStay (Collider other)
    {
        print(other.gameObject.name + " is still in the cube");
>>>>>>> 075f888 (add TIYs)
=======
        print(other.gameObject.name + " has entered the " + gameObject.name);
    }
    void OnTriggerStay (Collider other)
    {
        print(other.gameObject.name + " is still in the " + gameObject.name);
>>>>>>> 4bc1069 (add H9)
    }

    void OnTriggerExit (Collider other)
    {
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 4bc1069 (add H9)
        print(other.gameObject.name + " has left the " + gameObject.name);
    }

    void OnCollisionEnter (Collision collider)
    {
        print(collider.gameObject.name + " has entered the " + gameObject.name);
    }
    void OnCollisionStay (Collision collider)
    {
        print(collider.gameObject.name + " is still in the " + gameObject.name);
    }

    void OnCollisionExit (Collision collider)
    {
        print(collider.gameObject.name + " has left the " + gameObject.name);
<<<<<<< HEAD
=======
        print(other.gameObject.name + " has left the cube");
>>>>>>> 075f888 (add TIYs)
=======
>>>>>>> 4bc1069 (add H9)
    }
}
