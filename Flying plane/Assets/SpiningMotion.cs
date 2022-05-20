using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiningMotion : MonoBehaviour
{
    public Vector3 rotationValue;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationValue * Time.deltaTime * rotationSpeed);
    }
}
