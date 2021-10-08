using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SamplePolyforfism : ScriptableObject
{
    public abstract void Draw();
}

[CreateAssetMenu]
public class Circle : SamplePolyforfism
{
    public override void Draw() => Debug.Log("en");
}

[CreateAssetMenu]
public class Rectangle : SamplePolyforfism
{
    public override void Draw()
    {
        Debug.Log("rec");
    }
}
