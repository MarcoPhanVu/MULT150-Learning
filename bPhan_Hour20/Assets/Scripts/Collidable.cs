using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameManager manager;
    public float moveSpeed = 20f;
    public float timeAmount = 1.5f;

    void Update()
    {
        transform.Translate(0, 0, -moveSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("colliding with " + gameObject.name);   
            manager.AdjustTime(timeAmount);
            Destroy(gameObject);
        }
    }
}
