using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Circle : Shape
{
    [SerializeField] GameObject test;

    public override void Draw()
    {
        Instantiate(test);
    }
    
}
