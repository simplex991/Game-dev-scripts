using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    public Transform sphereTransform;

    // Start is called before the first frame update
    void Start()
    {
        sphereTransform.parent = transform; // Parents sphere to cube
    }

    // Update is called once per frame
    void Update()
    {
        // Rotating objects
        //transform.eulerAngles += Vector3.up * 180 * Time.deltaTime; // Vector.up => Vector3(0, 1, 0)
        transform.Rotate(Vector3.up * 180 * Time.deltaTime, Space.World); // Space.World = global space | Space.Self = object space
        // eulerAngles makes the child object rotate around the parents global space
        // Rotate makes the child object rotate around the parents object space
    }
}
