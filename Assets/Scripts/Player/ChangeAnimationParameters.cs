using System;
using UnityEngine;
using System.Collections;

public class ChangeAnimationParameters : MonoBehaviour
{
	private Animator anim;

	public bool facingRight = true;

	void Start()
	{
		this.anim = GetComponent<Animator>();
	}

	public void SetSpeed(float move)
	{
		anim.SetFloat("Speed", Mathf.Abs(move));
	}

	public void SetVerticalSpeed(float vMove)
	{
		anim.SetFloat("VSpeed", vMove);
	}

	public void Flip()
	{
		facingRight = !facingRight;
		// We take our scale and flip it to the opposite X
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

	public void SetFiringTop(bool boolean)
	{
		this.anim.SetBool("FiringTop", boolean);
	}

	public void SetFiringBot(bool boolean)
	{
		this.anim.SetBool("FiringBot", boolean);
	}

	public void SetFiringLeft(bool boolean)
	{
		if (facingRight)
		{
			Flip();
		}
		this.anim.SetBool("FiringSideways", boolean);
	}

	public void SetFiringRight(bool boolean)
	{
		if (!facingRight)
		{
			Flip();
		}
		this.anim.SetBool("FiringSideways", boolean);
	}

	public void ResetBools()
	{
		this.anim.SetBool("FiringTop", false);
		this.anim.SetBool("FiringBot", false);
		this.anim.SetBool("FiringSideways", false);
	}
}
