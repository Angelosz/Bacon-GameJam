using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour
{
	public GameObject player;

	void Update () {
		this.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 15, player.transform.position.z - 9);
	}
}
