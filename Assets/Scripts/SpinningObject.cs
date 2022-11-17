using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningObject : MonoBehaviour
{

    public float rotationSpeedX = 50;
    public float rotationSpeedY = 0;
    public float rotationSpeedZ = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationSpeedX*Time.deltaTime, rotationSpeedY*Time.deltaTime, rotationSpeedZ*Time.deltaTime);
    }
}
