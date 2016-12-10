using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : Singleton<GameManager>
{
	protected GameManager() { }

	public static class Scenes
	{
		public const string Splash = "SplashScreen";
		public const string Menu = "MainMenu";
		public const string Island = "Island";
	}

	private MainBase mainBase;

	public MainBase MainBase
	{
		get
		{
			return mainBase;
		}
	}

	public void HandleExit()
	{
		Application.Quit();
	}

	public void HandleExitIsland()
	{
		SceneManager.LoadScene(Scenes.Menu);
	}

	public void HandleGameStart()
	{
		SceneManager.LoadScene(Scenes.Island);
	}

	public void LoadScene(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}

	public void SetMainBase(MainBase mainBase)
	{
		this.mainBase = mainBase;
	}

	
}
