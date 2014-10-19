using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {
	public GameObject bullet;
	public int bulletVelocity;
	public float timeBetweenShots = 0.2222f;
	private float saveTimeBetweenShots;
	public bool canShoot;

	void Start () {
		saveTimeBetweenShots = timeBetweenShots;
	}

	void Update () {
		timeBetweenShots-= Time.deltaTime;

		if ((timeBetweenShots <= 0) && (!canShoot))
		{
			canShoot = true;
			this.GetComponent<PlayerMovement>().resetAnimatorBooleans();
		}

		if ((canShoot) && (Input.GetKey(KeyCode.I)))
		{
			GameObject GO = (GameObject)Instantiate(bullet, new Vector3(this.transform.position.x,
				this.transform.position.y, this.transform.position.z + 1), Quaternion.identity);
			GO.transform.GetChild(0).transform.rotation = Quaternion.Euler(new Vector3(90, 90, 0));
			GO.rigidbody.AddForce(Vector3.forward * Time.deltaTime *  bulletVelocity);
			timeBetweenShots = saveTimeBetweenShots;
			this.GetComponent<PlayerMovement>().changeAnimationScript.SetFiringTop(true);
			canShoot = false;
		}
		if ((canShoot) && (Input.GetKey(KeyCode.K)))
		{
			GameObject GO = (GameObject)Instantiate(bullet, new Vector3(this.transform.position.x,
				this.transform.position.y, this.transform.position.z - 1), Quaternion.identity);
			GO.transform.GetChild(0).transform.rotation = Quaternion.Euler(new Vector3(90, -90, 0));
			GO.rigidbody.AddForce(-Vector3.forward * Time.deltaTime *  bulletVelocity);
			timeBetweenShots = saveTimeBetweenShots;
			this.GetComponent<PlayerMovement>().changeAnimationScript.SetFiringBot(true);
			canShoot = false;
		}
		if ((canShoot) && (Input.GetKey(KeyCode.J)))
		{
			GameObject GO = (GameObject)Instantiate(bullet, new Vector3(this.transform.position.x - 1,
				this.transform.position.y, this.transform.position.z), Quaternion.identity);
			GO.rigidbody.AddForce(Vector3.left * Time.deltaTime *  bulletVelocity);
			timeBetweenShots = saveTimeBetweenShots;
			this.GetComponent<PlayerMovement>().changeAnimationScript.SetFiringLeft(true);
			canShoot = false;
		}
		if ((canShoot) && (Input.GetKey(KeyCode.L)))
		{
			GameObject GO = (GameObject)Instantiate(bullet, new Vector3(this.transform.position.x + 1,
				this.transform.position.y, this.transform.position.z), Quaternion.identity);
			GO.transform.GetChild(0).transform.rotation = Quaternion.Euler(new Vector3(30, 0, 180));
			GO.rigidbody.AddForce(Vector3.right * Time.deltaTime *  bulletVelocity);
			timeBetweenShots = saveTimeBetweenShots;
			this.GetComponent<PlayerMovement>().changeAnimationScript.SetFiringRight(true);
			canShoot = false;
		}
	}
}
