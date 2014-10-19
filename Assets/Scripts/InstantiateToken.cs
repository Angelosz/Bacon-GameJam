using UnityEngine;
using System.Collections;

public class InstantiateToken : MonoBehaviour {
	public GameObject guard;
	public GameObject user;

	public void instantiateGuard()
	{
		Instantiate(guard, transform.position, Quaternion.identity);
	}
	public void instantiateUser()
	{
		Instantiate(user, transform.position, Quaternion.identity);
	}
}
