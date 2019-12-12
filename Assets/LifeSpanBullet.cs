using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSpanBullet : MonoBehaviour
{
    public int bounces_times = 1;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Wall")
        {
            if (count >= bounces_times)
            {
                Destroy(gameObject);
            }
            count++;
        }
    }
}
