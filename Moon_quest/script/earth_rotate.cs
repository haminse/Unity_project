using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earth_rotate : MonoBehaviour
{

    public float EarthrotateSpeed;


    void Update()
    {
        transform.Rotate(Vector3.up * EarthrotateSpeed * Time.deltaTime, Space.World); // rotate with y axis
    }
 


}
