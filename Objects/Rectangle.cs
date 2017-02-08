using System;
using System.Collections.Generic;

namespace Rectangles.Objects
{
  public class Rectangle
  {
    //Declare all private values
    private int _length;
    private int _width;
    private static List<Rectangle> _instances = new List<Rectangle>{};
    //Make public constructor
    public Rectangle(int Length, int Width)
    {
      _length = Length;
      _width = Width;
    }
    //Make public List
    public static List<Rectangle> GetSides()
    {
      return _instances;
    }
    //Make public integers
    public int GetLength()
    {
      return _length;
    }
    public void SetLength(int inputLength)
    {
      _length = inputLength;
    }
    public int GetWidth()
    {
      return _width;
    }
    public void SetWidth(int inputWidth)
    {
      _width = inputWidth;
    }
    //Make public function
    public int GetArea()
    {
      return _length * _width;
    }
    public void SaveRectangle()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    //Make public boolean
    public bool IsSquare()
    {
      if (_length == _width)
      {
        return true;
      } else
      {
        return false;
      }
    }
  }
}
