using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMovement : MonoBehaviour
{

    public float speed = 5.0f;
    public float circleRadius = 5.0f;
    public Vector3 circleCenter = new Vector3(0f, 0f, 0f);
    private float theta = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {

        float xNew = circleRadius * Mathf.Sin(theta);
        float zNew = circleRadius * Mathf.Cos(theta);
        transform.position = new Vector3(xNew+circleCenter.x, 0.75f, zNew+circleCenter.z);
        theta += 0.1f*speed * Time.deltaTime;
    }

}
