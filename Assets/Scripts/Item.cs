using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.down*speed*Time.deltaTime);
		if(transform.position.y < -16){
			Destroy(gameObject);
		}
	}
	public virtual void getItem(GameObject paddle){
	}
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "paddle"){
			getItem(other.gameObject);
			Destroy(gameObject);
		}
	}
}
