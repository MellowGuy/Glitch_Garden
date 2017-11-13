using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	public float autoLoadNextLevelAfter;

	public void Start()
	{
		Invoke("LoadNextLevel", autoLoadNextLevelAfter);
	}

	//Loads level based on string passed in.
	public void LoadLevel(string name)
	{
		SceneManager.LoadScene(name);
		Debug.Log("New Level load: " + name);
		
		//Application.LoadLevel(name);
	}

	public void LoadNextLevel()
	{
		Application.LoadLevel(Application.loadedLevel + 1);
	}

	//Quits application
	public void QuitRequest()
	{
		Debug.Log("Quit requested");
		Application.Quit();
	}

}
