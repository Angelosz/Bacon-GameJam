using UnityEngine;
using System.Collections;

public class UserBehavior : MonoBehaviour {
	private GameObject myApp;
	// Use this for initialization
	void Start () {
		myApp = GameObject.Find("MyApp");
	}
	
	// Update is called once per frame
	void Update () {
		if (myApp == null) Destroy(gameObject);
			gameObject.GetComponent<NavMeshAgent>().destination = myApp.transform.position;
	}
}
