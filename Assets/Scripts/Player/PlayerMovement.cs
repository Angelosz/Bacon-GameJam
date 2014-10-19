using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float maxSpeed = 10f;

	public GameObject quad;

	public ChangeAnimationParameters changeAnimationScript;

	void Start()
	{
		changeAnimationScript = quad.GetComponent<ChangeAnimationParameters>();
	}

	void FixedUpdate()
	{
		/** 	Running		**/
		// How much I am moving
		float move = Input.GetAxis("Horizontal");
		float vMove = Input.GetAxis("Vertical");
		// Set Speed parameter to active Run animation
		changeAnimationScript.SetSpeed(move);
		changeAnimationScript.SetVerticalSpeed(vMove);

		rigidbody.velocity = new Vector3(move * maxSpeed, 0, vMove * maxSpeed);

		if (move > 0 && !changeAnimationScript.facingRight && this.GetComponent<PlayerShoot>().canShoot)
			changeAnimationScript.Flip();
		else if (move < 0 && changeAnimationScript.facingRight && this.GetComponent<PlayerShoot>().canShoot)
			changeAnimationScript.Flip();
	}

	public void resetAnimatorBooleans()
	{
		changeAnimationScript.ResetBools();
	}
}
