using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour {
	Vector2 randomPoint;
	float randomX, randomY;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		EnemyMoveRandom();
	}
	void EnemyMoveRandom(){
		randomPoint = new Vector2(randomX, randomY);
		transform.position = Vector2.MoveTowards(transform.position, randomPoint, 5* Time.deltaTime);
		if(Vector2.Distance(transform.position, randomPoint) <= 0)
		{
			randomX = Random.Range(-8.81f, 8.3f);
			randomY = Random.Range(-4.66f, 4.67f);
		}
	}
// 		private void OnTriggerEnter2D(Collider2D collision)
// 	{
// 		if(collision.gameObject.tag=="bullet")
// 		{
// 			Destroy(gameObject);
// 		}
// }
}
