using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
        public GameObject obstaclePrefab;
        private float startDelay = 2;
        private float repeatRate = 2;
        private playerController  playerControllerScript;
        private Vector3 spawnPosition = new Vector3(25, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("player").GetComponent<playerController>();
    }

    // Update is called once per frame
    void Update()
    {
    
        
    }
void SpawnObstacle(){
    if(!playerControllerScript.gameOver){
             Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
        }
   
}

}
