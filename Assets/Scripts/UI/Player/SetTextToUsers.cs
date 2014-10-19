using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class SetTextToUsers : MonoBehaviour
{
	private Text text;

	void Start()
	{
		this.text = this.GetComponent<Text>();
	}

	void Update ()
	{
		this.text.text = "You have " + GameController.users + " users.";
	}
}
