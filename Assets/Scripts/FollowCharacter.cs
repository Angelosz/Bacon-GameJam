using UnityEngine;
using System.Collections;

public class FollowCharacter : MonoBehaviour
{
	public GameObject character;

	void Update()
	{
		if(character != null)
			this.transform.position = new Vector3(character.transform.position.x, character.transform.position.y + 0.5f, character.transform.position.z);
	}
}
