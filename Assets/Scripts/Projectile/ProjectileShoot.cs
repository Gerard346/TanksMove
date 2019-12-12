using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShoot : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject projectile;
    public float speed = 40.0f;
    void Start()
    {
        projectile = Resources.Load("projectile") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(projectile) as GameObject;
            projectile.transform.position = transform.position;

            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.velocity = transform.forward * speed;
        }
    }
}
