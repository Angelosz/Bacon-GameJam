using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour
{
	private int healthPoints;

	void Awake()
	{
		this.healthPoints = 100;
	}

	public void TakeDamage(int damage)
	{
		this.healthPoints -= damage;
		if (this.healthPoints <= 0)
		{
			Application.LoadLevel(0);
			Destroy(this.gameObject);
		}
	}

	public int HealthPoints
	{
		get { return healthPoints; }
		set { healthPoints = value; }
	}
}
