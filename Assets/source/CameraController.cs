using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour 
{
	public float HorizontalSpeed = 100.0f;
	public float VerticalSpeed = 100.0f;
	public float HorizontalMin = 125.0f;
	public float HorizontalMax = 350.0f;
	public float VerticalMin = 125.0f;
	public float VerticalMax = 350.0f;

	// Update is called once per frame
	void Update () 
	{
		MoveHorizontally(Input.GetAxis("Horizontal"));
		MoveVertically(Input.GetAxis("Vertical"));
	}

	/// <summary>
	/// Horizontal movement moves the camera left and right
	/// </summary>
	/// <param name="axisValue"></param>
	private void MoveHorizontally(float axisValue)
	{
		if (axisValue != 0)
		{
			// Move left right if we are not outside bounds
			Vector3 localPosition = Camera.main.transform.localPosition;
			float newX = localPosition.x + (Time.deltaTime * HorizontalSpeed * axisValue);
			if (newX > HorizontalMin && newX < HorizontalMax)
			{
				Camera.main.transform.localPosition = new Vector3(newX, localPosition.y, localPosition.z);
			}
		}
	}

	/// <summary>
	/// Vertical movement moves the camera forward and backward
	/// </summary>
	/// <param name="axisValue"></param>
	private void MoveVertically(float axisValue)
	{
		if (axisValue != 0)
		{
			// Move forward backward if not outside bounds
			Vector3 localPosition = Camera.main.transform.localPosition;
			float newZ = localPosition.z + (Time.deltaTime * VerticalSpeed * axisValue);
			if (newZ > VerticalMin && newZ < VerticalMax)
			{
				Camera.main.transform.localPosition = new Vector3(localPosition.x, localPosition.y, newZ);
			}
			
		}
	}
}
