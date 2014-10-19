using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HpBarController : MonoBehaviour
{
	private Slider slider;
	public GameObject player;

	void Start ()
	{
		this.slider = this.GetComponent<Slider>();
		if (player.GetComponent<PlayerStats>() != null)
		{
			this.slider.maxValue = player.GetComponent<PlayerStats>().HealthPoints;
		}

	}
	
	void Update ()
	{
		if (player == null) return;
		if (player.GetComponent<PlayerStats>() != null)
			this.slider.value = player.GetComponent<PlayerStats>().HealthPoints;
	}
}
