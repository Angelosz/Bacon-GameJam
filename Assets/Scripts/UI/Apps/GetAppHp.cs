using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GetAppHp : MonoBehaviour
{
	private Slider slider;

	public GameObject app;

	void Start()
	{
		this.slider = this.GetComponent<Slider>();
		this.slider.maxValue = app.GetComponent<AppController>().HealthPoints;
		this.slider.value = app.GetComponent<AppController>().HealthPoints;
	}
	
	void Update ()
	{
		this.slider.value = app.GetComponent<AppController>().HealthPoints;
	}
}
