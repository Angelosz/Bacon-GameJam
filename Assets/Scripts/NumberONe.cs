using UnityEngine;
using System.Collections;

public class NumberONe : MonoBehaviour {
	public bool end = false;
	private float count = 5;

	void Update () {
		if(end)
		{
			count-= Time.deltaTime;
			if(count <= 0) Application.LoadLevel(1);
		}
	}
}
