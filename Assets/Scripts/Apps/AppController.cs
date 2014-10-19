using System;
using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class AppController : MonoBehaviour
{
	private int numberOfUsers;
	private int healthPoints;
	private int maxHealthPoints;
	private int numberOfGuards;

	public GameObject token;
	public GameObject winText;

	void Awake()
	{
		numberOfUsers = getHowManyUsersIHave();
		healthPoints = getHowManyHealthPointsIHave();
		maxHealthPoints = healthPoints;
		numberOfGuards = getHowManyGuardsIHave();
	}

	private int getHowManyGuardsIHave()
	{
		return Random.Range(10, 20);
	}

	private int getHowManyHealthPointsIHave()
	{
		return Random.Range(50, 75);
	}

	private int getHowManyUsersIHave()
	{
		return Random.Range(30, 60);
	}

	public void TakeDamage(int damage)
	{
		if (GameController.guardsOut < 30)
		{
			this.healthPoints -= damage;
			if (this.healthPoints <= 0)
			{
				GameController.remainingApps--;
				GameController.rankingPosition--;
				GameController.SetRanking();
				if (GameController.remainingApps <= 0)
				{
					winText.SetActive(true);
					winText.GetComponent<NumberONe>().end = true;
				}
				Destroy(this.gameObject);
			}

			if ((this.healthPoints < ((maxHealthPoints / 2) + maxHealthPoints / 4)) && (this.numberOfGuards > 0))
			{
				for (int i = 0; i < 5; i++)
				{
					GameController.guardsOut++;
					token.GetComponent<InstantiateToken>().instantiateGuard();
				}
				numberOfGuards -= 5;
			}


			if (this.healthPoints <= 0)
			{
				Destroy(this.gameObject);
				for (int i = 0; i < numberOfUsers; i++)
				{
					token.GetComponent<InstantiateToken>().instantiateUser();
				}
			}
		}
	}

	public int NumberOfUsers
	{
		get { return numberOfUsers; }
		set { numberOfUsers = value; }
	}

	public int HealthPoints
	{
		get { return healthPoints; }
		set { healthPoints = value; }
	}

	public int NumberOfGuards
	{
		get { return numberOfGuards; }
		set { numberOfGuards = value; }
	}

}
