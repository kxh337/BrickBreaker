using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	
	public Material[] bricks;
	public float fallSpeed;
	public int strength;
	public float startingY;
	public int step = 5;
	public int nextFall;

	public GameObject[] items;
	public float itemChance;

	// Use this for initialization
	void Start () {
		startingY = transform.position.y;
		setNextFall(step);
		strength = (Random.Range(0, bricks.Length));
		gameObject.renderer.material = bricks [strength];
	}

	// Update is called once per frame
	void Update () {
		if (GameManager.broken == nextFall) {
			startingY = startingY - 1.0f;
			nextFall = nextFall + step;
		}
		if (startingY < transform.position.y)
			transform.position = new Vector3 (transform.position.x, transform.position.y - fallSpeed, transform.position.z);
		if (transform.position.y <= - 11)
			Destroy(gameObject);

	}
	void DropItem(){
		if(Random.Range(0,100)<itemChance){
		int item = (int)Random.Range(0,items.Length);
		Instantiate(items[item],transform.position,transform.rotation);
		}
	}
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "Ball"){
			dealDamage();
		}
	}

	public void dealDamage(){
		if (strength <= 0){
			GameManager.broken++;
			Destroy(gameObject);
			DropItem();
		}
		else {
			strength--;	
			gameObject.renderer.material = bricks [strength];		
		}
	}

	public void setNextFall(int next){
		nextFall = next;
	} 

}
