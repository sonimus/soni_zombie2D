using UnityEngine;
using System.Collections;

public class bala : MonoBehaviour {
	public Vector2 velocity;
	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = velocity; //* transform.localScale;
	}
}
