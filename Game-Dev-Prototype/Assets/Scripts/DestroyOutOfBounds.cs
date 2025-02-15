using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 9f;
    private float lowerBound = -2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Delete objects out of view
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
