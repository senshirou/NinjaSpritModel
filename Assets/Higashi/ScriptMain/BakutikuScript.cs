using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BakutikuScript : MonoBehaviour
{
    float ZrotateSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //XTime += Time.deltaTime;
        transform.Rotate(0, 0, ZrotateSpeed, 0);
    }
}
