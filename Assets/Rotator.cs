using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed;

    float horizontal;
    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
    }

    void FixedUpdate() {
        transform.Rotate(Vector3.up * Time.deltaTime * horizontal * speed, Space.World);
    }
}
