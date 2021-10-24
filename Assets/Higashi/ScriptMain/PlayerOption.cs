using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerOption : MonoBehaviour
{
    public GameObject optionObj;
    int interval = 300;

    List<Vector3> playerPosition = new List<Vector3>();
    List<Quaternion> playerRotation = new List<Quaternion>();

    private void Start()
    {
        playerPosition.Add(transform.localPosition);
        playerRotation.Add(transform.localRotation);
    }

    private void Update()
    {
        if(playerPosition[playerPosition.Count - 1] != transform.localPosition || playerRotation[playerRotation.Count - 1] !=transform.localRotation)
        {
            playerPosition.Add(transform.localPosition);
            playerRotation.Add(transform.localRotation);

            if(playerPosition.Count > interval)
            {
                optionObj.transform.localPosition = playerPosition[0];
                optionObj.transform.localRotation = playerRotation[0];
                playerPosition.RemoveAt(0);
                playerRotation.RemoveAt(0);
            }
        }
    }
}
