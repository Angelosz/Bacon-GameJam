using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Guards : MonoBehaviour
{
	private Text text;

	void Start()
	{
		this.text = GetComponent<Text>();
	}
	void Update()
	{
		if (GameController.guardsOut >= 30)
		{
			this.text.text = "Kill the guards to destroy more Apps!";
		}
		else
		{
			this.text.text = "";
		}
	}
}
