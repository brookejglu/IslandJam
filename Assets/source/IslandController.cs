using UnityEngine;
using System.Collections;

public class IslandController : MonoBehaviour 
{
	public GameObject helpPanel;

	public void OnExitIsland()
	{
		GameManager.Instance.HandleExitIsland();
	}

	public void OnCloseHelpPanel()
	{
		Safe.HideObject(helpPanel);
	}

	public void OnOpenHelpPanel()
	{
		Safe.ShowObject(helpPanel);
	}
}
