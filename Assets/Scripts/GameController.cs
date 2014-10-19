using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
	public static int remainingApps;
	public static int users;
	public static int rankingPosition;
	public static int guardsOut;

	void Start()
	{
		setUpRemainingApps();
		setUpUsers();
		setUpRankingPosition();
		guardsOut = 8;
	}

	private void setUpRemainingApps()
	{
		remainingApps = 100;
	}

	private void setUpUsers()
	{
		if (PlayerPrefs.HasKey("users"))
		{
			users = PlayerPrefs.GetInt("users");
		}
		else
		{
			users = 0;
			PlayerPrefs.SetInt("users", users);
		}
	}

	private void setUpRankingPosition()
	{
		if (PlayerPrefs.HasKey("rankingPosition"))
		{
			rankingPosition = PlayerPrefs.GetInt("rankingPosition");
		}
		else
		{
			rankingPosition = Random.Range(15000, 25000);
			PlayerPrefs.SetInt("rankingPosition", rankingPosition);
		}
	}

	public static void SetUser()
	{
		PlayerPrefs.SetInt("users", users);
	}

	public static void SetRanking()
	{
		PlayerPrefs.SetInt("rankingPosition", rankingPosition - (GameController.users / 10));
	}

	public static void SetApps()
	{
		PlayerPrefs.SetInt("remainingApps", remainingApps);
	}

}
