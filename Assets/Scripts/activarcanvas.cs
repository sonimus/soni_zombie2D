using UnityEngine;
using System.Collections;

public class activarcanvas : MonoBehaviour {
	public GameObject canvas;
	public bool estacerca;
	public bool muestratexto = false;
	

	void OnTriggerEnter2D (Collider2D col){
				estacerca = true;
		}
	void OnTriggerEnter2D (Collider2D col){
				estacerca = false;
		}

	void Update () {
	if (estacerca){
				canvas.SetActive (true);
			}else{
				canvas.SetActive(false);
	}
   }

}
