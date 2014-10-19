using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InicialScene : MonoBehaviour {
	public GameObject textGO;
	private Text text;
	private float count = 4;
	private int i = 0;
	private string string1 = "We want to be millionare...";
	private string string2 = "but as app developers is hard...";
	private string string3 = "for there are millions and millions of Apps in the market.";
	private string string4 = "SO WE ARE GOING TO DESTROY THEM ALL (MUAHAHAH)";
	private string string5 = "We have created a virus that will erase every app at the store...";
	private string string6 = "... so our App is the number 1! ... Now... You are my creation...";
	private string string7 = "Will you pleasure me? Or will you be just another mistake...?";
	private string [] history;

	// Use this for initialization
	void Start ()
	{
		this.text = textGO.GetComponent<Text>();
		history = new string[7];
		history[0] = string1;
		history[1] = string2;
		history[2] = string3;
		history[3] = string4;
		history[4] = string5;
		history[5] = string6;
		history[6] = string7;
	}

	// Update is called once per frame
	void Update () {
		count-= Time.deltaTime;
		if(count <= 0)
		{
			i++;
			count = 4;
		}
		if (i > history.Length) ChangeToGame();

		text.text = history[i];
	}

	public void ChangeToGame()
	{
		Application.LoadLevel(1);
	}
}
