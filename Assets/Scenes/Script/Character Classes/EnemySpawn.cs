using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {
	GameObject Enemy1;
	GameObject Enemy2;
	GameObject Enemy3;
	
	Transform spawn1;
	Transform spawn2;
	Transform spawn3;
	
	void  spawnEnemies (){
		
		for(GameObject i=0;i<4;i++) {
			int random1 = Random.Range(0,3);
			
			switch (random1) {
			case (0):
				GameObject spawnEnemy1= Instantiate(Enemy1);
				switch (i) {
				case (0):
					spawnEnemy1.transform.position = new Vector3(spawn1.transform.position.x, spawn1.transform.position.y, spawn1.transform.position.z);
					spawnEnemy1.transform.tag = "enemy1";  
					break;
				case (1):
					spawnEnemy1.transform.position = new Vector3(spawn2.transform.position.x, spawn2.transform.position.y, spawn2.transform.position.z);
					spawnEnemy1.transform.tag = "enemy2";  
					break;
				case (2):
					spawnEnemy1.transform.position = new Vector3(spawn3.transform.position.x, spawn3.transform.position.y, spawn3.transform.position.z);
					spawnEnemy1.transform.tag = "enemy3";  
					break; 
				}
				break;           
			case (1):
				GameObject spawnEnemy2= Instantiate(Enemy2);
				switch (i) {
				case (0):
					spawnEnemy2.transform.position = new Vector3(spawn1.transform.position.x, spawn1.transform.position.y, spawn1.transform.position.z);
					spawnEnemy2.transform.tag = "enemy1";  
					break;
				case (1):
					spawnEnemy2.transform.position = new Vector3(spawn2.transform.position.x, spawn2.transform.position.y, spawn2.transform.position.z);
					spawnEnemy2.transform.tag = "enemy2";  
					break;
				case (2):
					spawnEnemy2.transform.position = new Vector3(spawn3.transform.position.x, spawn3.transform.position.y, spawn3.transform.position.z);
					spawnEnemy2.transform.tag = "enemy3";  
					break; 
				}
				break;  
			case (2):
				GameObject spawnEnemy3= Instantiate(Enemy3);
				switch (i) {
				case (0):
					spawnEnemy3.transform.position = new Vector3(spawn1.transform.position.x, spawn1.transform.position.y, spawn1.transform.position.z);
					spawnEnemy3.transform.tag = "enemy1";  
					break;
				case (1):
					spawnEnemy3.transform.position = new Vector3(spawn2.transform.position.x, spawn2.transform.position.y, spawn2.transform.position.z);
					spawnEnemy3.transform.tag = "enemy2";  
					break;
				case (2):
					spawnEnemy3.transform.position = new Vector3(spawn3.transform.position.x, spawn3.transform.position.y, spawn3.transform.position.z);
					spawnEnemy3.transform.tag = "enemy3";  
					break; 
				}
				break;  
				
			}
			
		}
		
	}
}