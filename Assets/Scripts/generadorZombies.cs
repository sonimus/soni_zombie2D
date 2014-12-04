using UnityEngine;
using System.Collections;

public class generadorZombies : MonoBehaviour {
	public GameObject Zombie;
	public float spamTime = 5f;
	public int maxZombies = 10;

	private float nextZombie;
	private float zcount = 0;

	void Start () {
		nextZombie = spamTime;
	}
	

	void Update () {
	if (Time.time > nextZombie) && (zcount < maxZombies)){
			nextZombie = Time.time + spamTime;
			var clone = Instantiate (Zombie, transform.position, Quaternion.identity) as GameObject;
			zcount++;
	       }
        }

}
