using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour {
	public float speed;
	public float yLimit;

	void Update(){
		gameObject.transform.Translate(Vector3.up*Time.deltaTime*speed);
		if(transform.position.y > yLimit){
			Destroy(gameObject);
		}
	}
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Brick"){
			Brick script = other.gameObject.GetComponent<Brick>();
			script.dealDamage();
			Destroy(gameObject);
		}
	}
}
