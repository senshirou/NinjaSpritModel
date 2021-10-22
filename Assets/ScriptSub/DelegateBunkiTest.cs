using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DelegateBunkiTest : MonoBehaviour
{
    public delegate void inFunction();

    private void Update()
    {
        inFunction inf = DebugLog1;
        
    }


    void DebugLog1()
    {
        Debug.Log("Hello");
    }
    
}
