using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KunaiScript : MonoBehaviour
{
    float speed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed;
        Destroy(gameObject, 3f);
    }
}
