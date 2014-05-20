using UnityEngine;
using System.Collections;

public class LaserCannon : MonoBehaviour {
	public GameObject laserPrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			GameObject laser = (GameObject)Instantiate(laserPrefab,transform.position,transform.rotation);
		}
	}
}
