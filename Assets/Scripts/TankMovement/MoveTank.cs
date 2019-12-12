using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTank : MonoBehaviour
{
    public float move_speed = 5.0f;
    public float rot_speed = 100.0f;

    float rotation = 0.0f;
    float move = 0.0f;
    Rigidbody tank;
    void Start()
    {
        tank = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rotation = Input.GetAxis("Horizontal1");
        move = Input.GetAxis("Vertical1");

        tank.velocity = move_speed * move * transform.forward;

        transform.Rotate(rotation * Vector3.up * rot_speed * Time.deltaTime);
    }
}
