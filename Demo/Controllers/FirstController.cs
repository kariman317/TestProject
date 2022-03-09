using Microsoft.AspNetCore.Mvc;
using System;

namespace Demo.Controllers
{
    //First
    public class FirstController : Controller
    {

        //first/myMEthod1
       public ContentResult myMethod1()
        {
            ContentResult result = new ContentResult();
            result.Content = "Hello From Method";
            return result;
        }
        //first/mymethod2
        public string myMethod2()
        {
            return "Hello From Method2";
        }

        //First/MyPage
        public ViewResult MyPage()
        {
            //declare object
            ViewResult result = new ViewResult();
            //set data
            /*
             /Views/First/Page1.cshtml
             /Views/Shared/Page1.cshtml
            */
            result.ViewName = "Page1";
            //return
            return result;
        }
        public IActionResult Mix()
        {
            if (DateTime.Now.Day == 13)
            {
                return Content("Hello From Method");
            }
            else if(DateTime.Now.Day == 1)
            {
                return Json(new { id=1,name="HAmada"});
            }
            else
            {
                return View("Page1");
            }
        }


    }
}
