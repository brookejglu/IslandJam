using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour 
{
	public void OnStartGame()
	{
		GameManager.Instance.HandleGameStart();
	}

	public void OnExitGame()
	{
		GameManager.Instance.HandleExit();
	}

}
