using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour 
{
	void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "Player")
		{
			if (other.GetComponent<PlayerStats>() != null)
			{
				other.GetComponent<PlayerStats>().TakeDamage(7);
			}
		}

		if ((other.transform.tag != "Enemy") && (other.transform.tag != "Projectile") && (other.transform.tag != "Explosion"))
			Destroy(this.gameObject);
	}
}
