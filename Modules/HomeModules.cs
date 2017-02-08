using Nancy;
using Rectangle.Objects;
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
      }
      Post["/rectangle-result"] = _ => {
        Rectangle inputRectangle = new Rectangle(Request.Form["length"],Request.Form["width"]);
        inputRectangle.SaveRectangle();
        return Vew["Rectangle-results.cshtml",inputRectangle];
      };
      Post["/rectangle_cleared"] = _ => {
        Rectangle.ClearAll();
        return View["Rectangle_cleared"];
      };
    }
  }
}
