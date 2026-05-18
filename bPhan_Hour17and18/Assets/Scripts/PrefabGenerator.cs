using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject lampPrefab;
    public Vector3 spawningRange, spawningPosition;

    void Start()
    {
        // Randomly spawn 5 lamps within the specified range
        // for (int i = 0; i < 5; i++)
        // {
        //     SpawnLampRandom();
        // }
        
        // Spawn 5 consecutive lamps in a line
        // Vector3 linePosition = spawningPosition;
        // for (int i = 0; i < 10; i++)
        // {
        //     if (i == 5)
        //     {
        //         linePosition = new Vector3(spawningPosition.x, spawningPosition.y, spawningPosition.z + 12f); // Reset position for the next(to) line
        //     }
        //     SpawnLampInLine(linePosition, 0); // 0 == x
        //     linePosition += new Vector3(10f, 0f, 0f);
        // }
    }

    void SpawnLampRandom()
    {
        Vector3 randomPosition = new Vector3(
            Random.Range(-spawningRange.x, spawningRange.x),
            1f,
            Random.Range(-spawningRange.z, spawningRange.z)
        );

        Instantiate(lampPrefab, spawningPosition + randomPosition, Quaternion.identity);
    }

    void SpawnLampInLine(Vector3 position, int direction)
    {
        if (direction == 0) // Spawn in x direction
        {
            position += new Vector3(10f, 0f, 0f);
        }
        else // Spawn in z direction
        {
            position += new Vector3(0f, 0f, 10f);
        }
        Instantiate(lampPrefab, spawningPosition + position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Vector3 linePosition = spawningPosition;
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    linePosition = new Vector3(spawningPosition.x, spawningPosition.y, spawningPosition.z + 12f); // Reset position for the next(to) line
                }
                SpawnLampInLine(linePosition, 0); // 0 == x
                linePosition += new Vector3(10f, 0f, 0f);
            }
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            for (int i = 0; i < 5; i++)
            {
                SpawnLampRandom();
            }
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            GameObject[] lamps = GameObject.FindGameObjectsWithTag("Lamp");
            foreach (GameObject lamp in lamps)
            {
                Destroy(lamp);
            }
        }
    }

    void OnGUI()
    {
        // Debug.Log("Check");
        Rect instruction = new Rect(20, 20, 400, 80);
        GUI.Box(instruction, "Press A to spawn lamps in a line \nB for random\nC for clear all lamps");
    }
}
