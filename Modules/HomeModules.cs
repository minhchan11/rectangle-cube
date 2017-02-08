using Nancy;
using Rectangles.Objects;
using System;
using System.Collections.Generic;

namespace RectangleChecker
{
  public class HomeModule: NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["Rectangle_forms.cshtml"];
      };
      Get["/rectangle_all"] = _ => {
        List<Rectangle> allRectangles = Rectangle.GetSides();
        return View["Rectangle_all.cshtml", allRectangles];
      };
      Post["/rectangle-result"] = _ => {
        Dictionary<string, object> Shapes = new Dictionary<string, object>();
        Rectangle inputRectangle = new Rectangle(Request.Form["length"],Request.Form["width"]);
        Shapes.Add("ResultingRectangle", inputRectangle);

        if (inputRectangle.IsSquare())
        {
          Cube inputCube = new Cube(inputRectangle);
          Shapes.Add("ResultingCube", inputCube);
        }
        inputRectangle.SaveRectangle();
        return View["Rectangle_results.cshtml", Shapes];
      };
      Post["/rectangle_cleared"] = _ => {
        Rectangle.ClearAll();
        return View["Rectangle_cleared.cshtml"];
      };
    }
  }
}
