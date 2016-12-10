using UnityEngine;
using System.Collections;

public class MainBase : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		// Register with the gamemanager
		GameManager.Instance.SetMainBase(this);
	}

	public void OnCollisionEnter(Collision collision)
	{
		// Something collided with me
		DestroyObject(collision.gameObject);
		Debug.Log("Something hit the base");
	}


	
}
