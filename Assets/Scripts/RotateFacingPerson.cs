using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateFacingPerson : MonoBehaviour
{

    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(cam.transform.rotation.x, transform.rotation.y, transform.rotation.z);
    }
}
