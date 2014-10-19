using UnityEngine;
using System.Collections;

public class myAppStats : MonoBehaviour
{
	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "User")
		{
			GameController.users++;
			GameController.SetUser();
			GameController.SetRanking();
			Destroy(other.transform.parent.gameObject);
		}
	}
}