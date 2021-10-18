using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ScriptableOb : ScriptableObject
{
    public int life;

    public virtual void Test()
    {
        Debug.Log("poly");
    }
}
