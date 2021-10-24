using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BakutikuGroupScript : MonoBehaviour
{
    float BakutikuSpeed = 0.15f;
    [SerializeField] GameObject BakutikuExplosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * BakutikuSpeed ;
        Destroy(gameObject, 4f);
    }

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(BakutikuExplosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
