using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class setTextToRemainingApps : MonoBehaviour
{
	private Text text;

	void Start()
	{
		this.text = this.GetComponent<Text>();
	}
	void Update ()
	{
		this.text.text = GameController.remainingApps + " apps remaining";
	}
}
