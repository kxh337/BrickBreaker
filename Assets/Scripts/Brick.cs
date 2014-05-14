using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	public GameObject[] items;
	public float itemChance;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void DropItem(){
		if(Random.Range(0,100)<itemChance){
		int item = (int)Random.Range(0,items.Length-1);
		Instantiate(items[item],transform.position,transform.rotation);
		}
	}
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "Ball"){
			DropItem();
			Destroy(gameObject);
		}

	}
}
