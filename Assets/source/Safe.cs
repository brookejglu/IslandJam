using UnityEngine;
using System.Collections;

public class Safe : Singleton<Safe>
{
	public static void HideObject(GameObject go)
	{
		if (go != null)
		{
			go.SetActive(false);
		}
	}

	public static void ShowObject(GameObject go)
	{
		if (go != null)
		{
			go.SetActive(true);
		}
	}
	
}
