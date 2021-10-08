using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamplePolyforfism1 : MonoBehaviour
{
    [SerializeField] private List<SamplePolyforfism> _Sample;

    private void Start()
    {
        foreach(var shape in _Sample)
        {
            shape.Draw();
        }
    }

}
