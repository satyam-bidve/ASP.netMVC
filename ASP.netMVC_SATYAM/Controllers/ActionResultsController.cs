using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.netMVC_SATYAM.Controllers
{
    public class ActionResultsController : Controller
    {
        // GET: ActionResults
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult ForView()  //returns a  view 
        {
            return View();
        }

        public EmptyResult ForEmpty() // returns nothing
        {
            return new EmptyResult();
        }

       
        public ContentResult ForContentResult()  // returns a content that can be string number etc here JS as a string that get executed 
        {
            string info = "<script>alert('Hello from the content this JS')</script>";
            return Content(info);
        }

        public FileResult ForDownloadFile()  // Download File Functionality need actual file at server
        {
            //Server.MapPath("/Content/Redhat.PDF") <- File path at server so from rootAppication to file

            // return File(filePath, contentType, "Redhat.PDF"); fileName last 

            return File(Server.MapPath("/Content/Redhat.PDF"), "application/pdf", "Redhat.PDF"); 
        }
        public RedirectResult ForRedirectResult()
        {
            
            return Redirect("https://www.google.com"); // redirect to other website better than anchor tag to know traffic monitering
        }

        public JavaScriptResult ForJavaScriptResult()
        {
            //string strJavascript = "console.log('Hello from server side." + DateTime.Now.ToString() + "')";

            string script = "$('#imgIcon').slideDown('slow', function(){});";
            return JavaScript(script);
        }
    }
}