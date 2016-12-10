using UnityEngine;
using System.Collections;

public class AttackerBrain : MonoBehaviour 
{
	private Rigidbody rigidBody = null;

	public float AttackerSpeed = 10.0f;

	void Start()
	{
		rigidBody = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () 
	{
		if (GameManager.Instance.MainBase != null && rigidBody != null)
		{
			// Head to the base
			MainBase mainBase = GameManager.Instance.MainBase;
			this.transform.LookAt(mainBase.transform.position);

			rigidBody.velocity = new Vector3(transform.forward.x * AttackerSpeed, rigidBody.velocity.y, transform.forward.z * AttackerSpeed);
			
		}
	}
}
