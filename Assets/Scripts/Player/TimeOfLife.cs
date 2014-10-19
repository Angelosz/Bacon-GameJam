using UnityEngine;
using System.Collections;

public class TimeOfLife : MonoBehaviour {
	public int seg = 1;
	private float count;

	void Start () {
		count = seg;
	}
	
	void Update () {
		count -= Time.deltaTime;
		if(count <= 0){
			Destroy(gameObject);
		}
	}
}
