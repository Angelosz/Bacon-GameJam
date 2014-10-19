using UnityEngine;
using System.Collections;

public class EnemyStats : MonoBehaviour
{
	private int healthPoints;

	void Start()
	{
		this.healthPoints = Random.Range(30, 70);
	}

	public void TakeDamage(int damage)
	{
		this.healthPoints -= damage;
		if (this.healthPoints <= 0)
		{
			GameController.guardsOut--;
			Destroy(this.transform.parent.gameObject);
		}
	}

	public int HealthPoints
	{
		get { return healthPoints; }
		set { healthPoints = value; }
	}
}
