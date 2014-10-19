using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetTextToRankingPosition : MonoBehaviour
{
	private Text text;
	void Start ()
	{
		this.text = this.GetComponent<Text>();
	}
	
	void Update ()
	{
		this.text.text = "#" + (GameController.rankingPosition - (GameController.users / 10));
	}
}
