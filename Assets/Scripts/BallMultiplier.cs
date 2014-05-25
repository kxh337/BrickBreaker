using UnityEngine;
using System.Collections;

public class BallMultiplier : Item {
	public GameObject ballPrefab;
	public int Minx;
	public int Maxx;
	public int Miny;
	public int Maxy;
	public bool multiplied;
	// Use this for initialization
	void Start () {
		multiplied = false;
	}


	public override void getItem(GameObject paddle){
		if(!multiplied){
		GameObject[] balls = GameObject.FindGameObjectsWithTag("Ball");
		foreach(GameObject ball in balls){
			Vector3 placement = ball.transform.position + Random.insideUnitSphere*3;
			float xPlace = Mathf.Clamp(placement.x,Minx,Maxx);
			float yPlace = Mathf.Clamp(placement.y,Miny,Maxy);
			placement = new Vector3(xPlace,yPlace,0);
			GameObject clone = (GameObject)Instantiate(ballPrefab,placement,ball.transform.rotation);
			clone.rigidbody.velocity = ball.rigidbody.velocity;
			BounceBar.ballCount++;
		}
		multiplied = true;
		}
	}
}
