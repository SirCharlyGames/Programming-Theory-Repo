using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    private Color color = Color.blue;
    private string nameOfShape = "Square";
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
