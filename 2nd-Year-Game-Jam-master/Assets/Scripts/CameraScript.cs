using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
	public GameObject Player;
	Vector3 playerWatch;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		playerWatch = new Vector3(Player.transform.position.x, transform.position.y, Player.transform.position.z - 20f);
		transform.position = playerWatch;
	}
}
