using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleGirlWiseCollider : MonoBehaviour {

	public void OnTriggerStay(Collider other) {
		print ("little girl collider activated");
		Player hit_player = other.GetComponent<Player> ();
		if (hit_player) {
			print ("Player is close");
		}
	}
}
\\