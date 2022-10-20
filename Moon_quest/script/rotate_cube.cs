using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_cube : MonoBehaviour
{
    public float rotateCubeSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * rotateCubeSpeed * Time.deltaTime, Space.World); // rotate with y axis
    }
}
