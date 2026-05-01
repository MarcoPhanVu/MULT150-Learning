using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float startSpeed = 8f;
    public GoalScript blue, green, red, orange;
    private bool isGameOver = true;
	private float elapsedTime = 0;

	private void StartGame()
	{
        elapsedTime = 0;
        blue.isSolved = false;
        green.isSolved = false;
        red.isSolved = false;
        orange.isSolved = false;
        isGameOver = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

    // Update is called once per frame
      void Update ()
    {
        // If all four goals are solved then the game is over
        // Debug.Log("Checking if game is over...");
        isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved;
        // if(Input.GetKeyDown(KeyCode.Return))
        // {
        //     Debug.Log("Enter check...");
        // }
        if (!isGameOver)
        {
            elapsedTime += Time.deltaTime;
        }
    }
    void OnGUI()
        {
            // Debug.Log("Checking if game is over in OnGUI...");  
        if(isGameOver)
        {
            int cappedTime = (int)elapsedTime;
            Rect rect = new Rect (Screen.width / 2 - 100, Screen.height /  2 + 50, 200, 75);
            GUI.Box (rect, "Game Over");
            Rect rect2 = new Rect (Screen.width / 2 - 30, Screen.height /  2 + 25, 60, 50);
            GUI.Label (rect2, "Good Job!");

            Rect restartButton = new Rect(Screen.width/2 - 120, Screen.height/2 + 120, 240, 30);

            string message = "Press Enter to replay";
            GUI.Label(restartButton, message);

            GUI.Box(new Rect(Screen.width / 2 - 65, 185, 130, 40), "Your Time Was");

			GUI.Label(new Rect(Screen.width / 2 - 10, 200, 20, 30), cappedTime.ToString());

            if (Input.GetKeyDown(KeyCode.Return))
			{
                Debug.Log("Restarting Game...");
                StartGame();
				// start the game if the user clicks to play
			}
            }
        }
    }
