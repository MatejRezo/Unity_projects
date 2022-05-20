using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{   
    public float speed = 30;
    private playerController  playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("player").GetComponent<playerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!playerControllerScript.gameOver){
             transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if(transform.position.y < (-1) ){
            Destroy(gameObject);
        };
    }
}
