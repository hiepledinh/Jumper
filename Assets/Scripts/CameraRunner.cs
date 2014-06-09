using UnityEngine;
using System.Collections;

public class CameraRunner : MonoBehaviour
{

	public Transform player;
	void Update ()
	{
		if (player.position.y > transform.position.y) {
			transform.position = new Vector3 (0, player.position.y, -10);
		}
	}
}
