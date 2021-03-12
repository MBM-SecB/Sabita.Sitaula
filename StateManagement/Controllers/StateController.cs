using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

public class StateController : Controller
{
    public ViewResult First()
    {
        // Statemanagement
        //1.Client side   
        //1.1 Cookies
        var name="Sabita Sitaula";
        Response.Cookies.Append("user",name);

        //2.Server side
        //2.1 Session
        HttpContext.Session.SetString("Address", "Jhapa");

        
        return View();
    }

    public ViewResult Second(string name,int age) //1.2 Query strings (Query parameters)
    {
        var userAddress = HttpContext.Session.GetString("Address");

        //2.2 Temp data
        TempData["CollegeName"]="MBM College";

        return View();
    }

    public ViewResult Third() 
    {

        //2.2 Temp data
         var cName=TempData["CollegeName"];

        byte value = 67;

        ViewData["Name1"]="abc from Viewdata";
        ViewBag.Name ="abc from ViewBag";
        return View(value);
    }

    [HttpPost]
    public string Second(string collegeName) //1.3 Hidden fields
    {
        return collegeName;
    }
}