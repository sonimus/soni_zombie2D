using UnityEngine;
using System.Collections;

public class nextlevel : MonoBehaviour {
	
	public string nombreNivel = "zombie3";
		bool cargando = false;


	//void Update(){
		//if (Input.GetKeyDown (KeyCode.Space) && delantepuerta) {
		//	teletransporta = true;
		//}
	//}
	void OnTriggerEnter2D (Collider2D target){
		if (target.transform.tag == "Player")
						Application.LoadLevel (nombreNivel);
	}
	
	//void OnTriggerStay2D(Collider2D target){
	//	if (teletransporta){ 
			//target.transform.position = destino.position;
			//teletransporta = false;
			//delantepuerta = false;
		//}
	//}
	//void OnTriggerExit2D (Collider2D target){
		//if (target.transform.tag == "Player")
		//	delantepuerta = false;
	//}
	
}