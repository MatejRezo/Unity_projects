using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    private float speed = 10.0f;
    public float zBoundry;
    private Rigidbody playerRB;
    

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        offTheBounds();
    }

    void Movement(){
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime , Space.World);
        transform.Translate(Vector3.right * speed * horizontalInput *Time.deltaTime , Space.World);

          RaycastHit hit;
         Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
 
         if(Physics.Raycast(ray,out hit,100))
        {
         transform.LookAt(new Vector3(hit.point.x,transform.position.y,hit.point.z));
         }
    }

    void offTheBounds(){
        if(transform.position.z < -zBoundry){
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBoundry);
        } 
        if(transform.position.z > zBoundry){
            transform.position = new Vector3(transform.position.x, transform.position.y, zBoundry);
        } 
    }
}
