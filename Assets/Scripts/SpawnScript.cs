using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour
{

	public GameObject[] obj;
	//public float spawnMin = 1f;
	//public float spawnMax = 2f;
	float platformsSpawnedUpTo = 0.0f;
	float nextPlatformCheck = 0.0f;
	public Transform player;

	void Start ()
	{
		//SpawnPlatforms (25.0f);
	}

	void Update ()
	{
		float playerHeight = player.position.y;
		if (playerHeight > nextPlatformCheck) {
			PlatformMaintenaince (); //Spawn new platforms
		}
	}

	void PlatformMaintenaince ()
	{
		nextPlatformCheck = player.position.y + 10;
		//Spawn new platforms, 25 units in advance
		SpawnPlatforms (nextPlatformCheck + 25);
	}

	void SpawnPlatforms (float upTo)
	{
		float spawnHeight = platformsSpawnedUpTo;
		while (spawnHeight <= upTo) {
			float x = Random.Range (-4.0f, 4.0f);
			Vector3 pos = new Vector3 (x, spawnHeight, 12.0f);
			
			Instantiate (obj [Random.Range (0, obj.GetLength (0))], pos, Quaternion.identity);
						
			spawnHeight += Random.Range (1.6f, 3.5f);
		}
		platformsSpawnedUpTo = upTo;
		//Invoke ("Spawn", Random.Range (spawnMin, spawnMax));
	}

}
