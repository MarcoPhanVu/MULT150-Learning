using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float health = 1004f;
        float poisonDamage = 125.5f;
        Debug.Log("Player Health: " + health);


        while (health > 0) {
            health -= poisonDamage;
            Debug.Log("Player Health after poison: " + health);
        }

        if (health <= 0) {
            health = 0;
            Debug.Log("Player is ceased to alive.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
