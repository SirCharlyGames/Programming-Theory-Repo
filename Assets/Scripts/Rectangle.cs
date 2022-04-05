using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : Shape
{
    private Color color = Color.red;
    private string nameOfShape = "Rectangle";
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
