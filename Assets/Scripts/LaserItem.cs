using UnityEngine;
using System.Collections;

public class LaserItem : Item {
	public float duration;
	// Use this for initialization
	void Start () {
	
	}
	

	public override void getItem(GameObject paddle){
		BounceBar barScript = paddle.GetComponent<BounceBar>();
		barScript.LaserOn(duration);
	}
}
