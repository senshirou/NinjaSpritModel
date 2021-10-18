using System.Collections.Generic;
using UnityEngine;

public class Drawer : MonoBehaviour
{
    [SerializeField]  List<Shape> _shapes;

    private void Start()
    {
        foreach (var shape in _shapes)
        {
            shape.Draw();
        }
    }
}
