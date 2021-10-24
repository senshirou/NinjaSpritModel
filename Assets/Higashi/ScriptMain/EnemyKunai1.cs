using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKunai1 : MonoBehaviour
{
    public GameObject player;
    public GameObject ball;
    public float ballSpeed = 10.0f;



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        transform.LookAt(player.transform);
        StartCoroutine(nameof(BallShot));



    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
    }


    IEnumerator BallShot()
    {
        while(true)
        {
            var shot = Instantiate(ball, transform.position, transform.rotation);
            shot.GetComponent<Rigidbody>().velocity = transform.forward.normalized * ballSpeed;
            yield return new WaitForSeconds(1.0f);
        }
    }


}
