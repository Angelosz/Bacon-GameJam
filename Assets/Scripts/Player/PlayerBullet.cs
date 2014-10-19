using UnityEngine;
using System.Collections;

public class PlayerBullet : MonoBehaviour
{
	public GameObject explosion;

	void OnTriggerEnter(Collider other)
	{
		if ((other.transform.tag != "Player") && (other.transform.tag != "Projectile") && (other.transform.tag != "Explosion"))
		{ 
			Instantiate(explosion, this.transform.position, Quaternion.identity);
			Destroy(this.gameObject);
		}
	}
}
