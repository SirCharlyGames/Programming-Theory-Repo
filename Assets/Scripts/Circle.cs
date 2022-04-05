using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape
{
    private Color color = Color.green;
    private string nameOfShape = "Circle";
    private void OnMouseDown()
    {
        SetName();
        SetColor();
        PrintColorAndName();
    }
    protected override void SetColor()
    {
        ShapeColor = color;
        base.SetColor();
    }
    protected override void SetName()
    {
        ShapeName = nameOfShape;
        base.SetName();
    }
}
