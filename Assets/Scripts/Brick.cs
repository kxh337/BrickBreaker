using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
<<<<<<< HEAD
	
	public Material[] bricks;

	public int strength;

=======
	public GameObject[] items;
	public float itemChance;
>>>>>>> FETCH_HEAD
	// Use this for initialization
	void Start () {
		strength = (Random.Range(0, bricks.Length));
		gameObject.renderer.material = bricks [strength];
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
<<<<<<< HEAD
			if (strength <= 0)
				Destroy(gameObject);
			else {
				strength--;
				gameObject.renderer.material = bricks [strength];
			}
=======
			DropItem();
			Destroy(gameObject);
>>>>>>> FETCH_HEAD
		}
	}
	
}
