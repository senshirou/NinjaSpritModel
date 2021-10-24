using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ScriptableOb2 : MonoBehaviour
{
    int a = 10;
    int b = 20;
    

    // Start is called before the first frame update
    private void Start()
    {
        var list = new List<int>();
        for (int i = 0; i < 20; i++)
        {
            list.Add(i);
        }

        List<int> result = list.FindAll(i => i % 2 == 0);
        foreach(var v in result)
        {
            Debug.Log(v);
        }

        var lists = new List<int> { 1, 3, 4, 5 };

        list.ForEach(v => Debug.Log(v * v));

        Action<int,int> action = lamuda;
        action(10,20);

        Action<string> ac = lamuda2;
        ac("‚í‚Í‚Í");


        Func<int> func = CreationRandomNumber;
        var results = func();
        Debug.Log(results);


       


    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void lamuda(int a, int b)
    {
        Debug.Log(a+b);
    }

    void lamuda2(string a)
    {
        Debug.Log(a);
    }

    int CreationRandomNumber()
    {
        var random = new System.Random();
        return random.Next();
    }

    public int plus() => a + b;

    
}
