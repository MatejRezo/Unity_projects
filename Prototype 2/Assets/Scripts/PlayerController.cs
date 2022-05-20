using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float playerHorizontalInput;
    public float speed = 15.0f;
    public float xMaxRange = 15.0f;
    public GameObject projectilePrefab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        playerHorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right* playerHorizontalInput * speed *Time.deltaTime);

        if(transform.position.x < -xMaxRange){
            transform.position = new Vector3 (-xMaxRange, transform.position.y,transform.position.z);
        };

         if(transform.position.x> xMaxRange){
            transform.position = new Vector3 (xMaxRange, transform.position.y,transform.position.z);
        };

        if(Input.GetKeyDown(KeyCode.Space))
        {
           Instantiate(projectilePrefab, transform.position , projectilePrefab.transform.rotation);

        };
        
    }
}
