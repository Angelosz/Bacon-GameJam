using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {

	public void ChangeToGame()
	{
		if(PlayerPrefs.HasKey("NotFirstTime"))
			Application.LoadLevel(1);
		else
		{
			PlayerPrefs.SetInt("NotFirstTime", 1);
			Application.LoadLevel(2);
		}
	}
}
