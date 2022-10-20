using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_floor : MonoBehaviour
{

    public float rotateFloorSpeed;

    // Update is called once per frame
    void Update()
    {
         transform.Rotate(Vector3.forward * rotateFloorSpeed * Time.deltaTime, Space.World); // rotate with y axis
    }
}
