using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MOBGenerator : MonoBehaviour 
{
	public GameObject MOBPrefab;
	public int MOBCount = 5;
	public int TimeBetweenSpawn = 5;

	private float lastSpawn = 0;
	private int totalSpawn = 0;

	// Update is called once per frame
	void Update () 
	{
		if (totalSpawn >= MOBCount)
		{
			return;
		}

		lastSpawn += Time.deltaTime;

		if (lastSpawn >= TimeBetweenSpawn)
		{
			lastSpawn = 0;
			TrySpawnMob();
		}
		
	}

	private void TrySpawnMob()
	{
		if (totalSpawn < MOBCount)
		{
			Instantiate(MOBPrefab, this.transform.position, Quaternion.identity);
			totalSpawn++;
		}
	}

	public void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawCube(transform.position, Vector3.one * 10);
	}


}
