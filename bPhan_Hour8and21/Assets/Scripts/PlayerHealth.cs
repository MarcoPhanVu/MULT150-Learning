using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    int healthpoints = 3992;
    void Start()
    {
        Debug.Log("Player health: " + healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        Debug.Log("Player health after using potion: " + healthpoints);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int UsePotion(int healthpoints)
    {
        // healthpoints += health;
        healthpoints += 400;
        return healthpoints;
    }
}
