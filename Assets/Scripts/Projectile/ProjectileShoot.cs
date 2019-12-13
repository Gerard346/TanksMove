using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShoot : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject projectile;
    public GameObject sphere;
    public float speed = 40.0f;
    void Start()
    {
        projectile = Resources.Load("projectile") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //sphere.transform.position = transform.position;
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
            
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.velocity = transform.forward * speed;

        }
        
    }
}
