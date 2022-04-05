using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    private Color shapeColor;
    public Color ShapeColor
    {
        get { return shapeColor; }
        set
        {
            if (value == Color.green || value == Color.blue || value == Color.red)
            {
                shapeColor = value;
            }
            else
            {
                Debug.Log("Incorrect color selected");
            }
        }
    }
    private string shapeName;
    public string ShapeName
    {
        get { return shapeName; }
        set
        {
            if (value == "Square" || value == "Rectangle" || value == "Circle")
            {
                shapeName = value;
            }
            else
            {
                Debug.Log("Incorrect name selected");
            }    
        }
    }
    protected virtual void PrintColorAndName()
    {
        Debug.Log(shapeName);
    }
    protected virtual void SetColor()
    {
        Renderer renderer = gameObject.GetComponent<Renderer>();
        renderer.material.color = shapeColor;
    }
    protected virtual void SetName()
    {
        gameObject.name = shapeName;
    }
}
