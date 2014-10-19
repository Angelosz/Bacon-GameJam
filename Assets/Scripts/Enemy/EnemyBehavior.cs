using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour {
	private GameObject guardian;
	public GameObject bullet;
	public GameObject quad;
	private Animator anim;
	public int bulletVelocity;
	public float timeBetweenShots = 0.4f;
	private float savetimeBetweenShots;



	void Start () {
		guardian = GameObject.Find("Player");
		anim = quad.GetComponent<Animator>();
		savetimeBetweenShots = timeBetweenShots;
	}
	

	void Update ()
	{
		if (guardian == null) return;

		if (guardian.transform.position.x >= this.transform.position.x)
		{
			anim.SetFloat("Speed", 1);
		}
		else
		{
			anim.SetFloat("Speed", -1);
		}

		if (guardian.transform.position.z >= this.transform.position.z)
		{
			anim.SetFloat("VSpeed", 1);
		}
		else
		{
			anim.SetFloat("VSpeed", -1);
		}
	
		this.transform.LookAt (new Vector3(guardian.transform.position.x, guardian.transform.position.y, guardian.transform.position.z));
		if(Vector3.Distance(transform.position, guardian.transform.position) > 13){
			gameObject.GetComponent<NavMeshAgent>().destination = guardian.transform.position;
			anim.SetBool("Stopped", false);
		}else{
			attackPlayer();
			anim.SetBool("Stopped", true);
			gameObject.GetComponent<NavMeshAgent>().Stop(true);
		}
	}
	public void attackPlayer(){
		timeBetweenShots -= Time.deltaTime;
		if( timeBetweenShots <= 0){
			GameObject GO = (GameObject)Instantiate(bullet, transform.position, bullet.transform.rotation);

			if (guardian.transform.position.x < this.transform.position.x)
			{
				GO.transform.GetChild(0).transform.rotation = Quaternion.Euler(new Vector3(30, 0, 180));
			}
			else
			{
				GO.transform.GetChild(0).transform.rotation = Quaternion.Euler(new Vector3(30, 0, 0));
			}
				
			
			GO.rigidbody.AddRelativeForce(transform.rotation * Vector3.forward * Time.deltaTime *  bulletVelocity);
			timeBetweenShots = savetimeBetweenShots;
		}
	}
}