using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class MainCameraMoveScript : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Text;
    [SerializeField] TextMeshPro TimeText;
    [SerializeField] GameObject ClearText;

    float CameraPositionY = 10f;
    

    float time;
    float ClearTime;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        TimeText.text = time.ToString("F3");

        //transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, transform.position.z);

        try
        {
            transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y + CameraPositionY, transform.position.z);
        }
        catch(MissingReferenceException e)
        {
            Text.SetActive(true);
        }

        //if (ClearText.activeSelf == true)
        //{
        //    time -= Time.deltaTime;
        //    ClearTime = time;
        //    Debug.Log(ClearTime);
        //    TimeText.text = ClearTime.ToString("F3");
        //}
    }

   
}
