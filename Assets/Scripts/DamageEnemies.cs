using UnityEngine;
using System.Collections;

public class DamageEnemies : MonoBehaviour {

	void OnTriggerStay(Collider other)
	{
		if (other.transform.tag == "Enemy")
		{
			if (other.GetComponent<EnemyStats>() != null)
			{
				other.GetComponent<EnemyStats>().TakeDamage(1);
			}
		}

		if (other.transform.tag == "AppFactory")
		{
			if (other.GetComponent<AppController>() != null)
			{
				other.GetComponent<AppController>().TakeDamage(1);
			}
		}
	}
}
