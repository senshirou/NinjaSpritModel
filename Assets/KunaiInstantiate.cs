using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KunaiInstantiate : MonoBehaviour
{
    [SerializeField] GameObject Kunai;
    float fai = 45;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Instantiate(Kunai, transform.position, transform.rotation * Quaternion.Euler(4*fai, 0, 0));
            Instantiate(Kunai, transform.position, transform.rotation * Quaternion.Euler(3*fai, 0, 0));
            Instantiate(Kunai, transform.position, transform.rotation * Quaternion.Euler(2*fai, 0, 0));
            Instantiate(Kunai, transform.position, transform.rotation * Quaternion.Euler(1*fai, 0, 0));
            Instantiate(Kunai, transform.position, transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            Instantiate(Kunai, transform.position, transform.rotation * Quaternion.Euler(45, 0, 0));
        }

        else if (Input.GetKeyDown(KeyCode.J))
        {
            Instantiate(Kunai, transform.position, transform.rotation);
        }
    }
}
