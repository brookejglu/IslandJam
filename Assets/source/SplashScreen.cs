using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SplashScreen : MonoBehaviour 
{

	public void OnClickStart()
	{
		SceneManager.LoadScene(GameManager.Scenes.Menu);
	}

	public void OnClickExit()
	{
		GameManager.Instance.HandleExit();
	}
}
