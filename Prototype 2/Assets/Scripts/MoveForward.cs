using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed ;
    private float zMaxRange = 100;
    private float zMaxRangeNegative = -20;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);



         if(transform.position.z > zMaxRange){
            Destroy(gameObject);

        }else if(transform.position.z < zMaxRangeNegative){
            Debug.Log("Game over");
            Destroy(gameObject);
            }

            
        
    }
}
