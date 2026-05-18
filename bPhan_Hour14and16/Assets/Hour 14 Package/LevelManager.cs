using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	public string sceneToLoad = "Game_Placeholder";


	public void LoadGame ()
	{
		SceneManager.LoadScene(sceneToLoad);
	}
}
