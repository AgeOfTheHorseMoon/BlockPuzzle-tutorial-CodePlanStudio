using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class ShapeStorage : MonoBehaviour
{
    public List<ShapeData> ShapeData;
    public List<Shape> ShapeList;
    void Start()
    {
        foreach (var shape in ShapeList)
        {
            var shapeIndex = UnityEngine.Random.Range(0, ShapeData.Count);
            shape.CreateShape(ShapeData[shapeIndex]);
        }
    }
}
