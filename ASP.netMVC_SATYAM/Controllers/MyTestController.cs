using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.netMVC_SATYAM.Controllers
{
    // Controller -- is the CS file to handel the http req 
    // can control the flow of apllication  and proide data to corrosponding view 
    // redirect other view and send responce 
    public class MyTestController : Controller
    {
        // ActionMethod -- public to access from browser 
        // defoult return type is ActionResult - return JSON , view , Partial View  , file , String...
        // to return view we need to create one in view -> MyTest -> here
        // http://localhost:56808/MyTest/Index
        public ActionResult Index()
        {
            return View("View");
        }

        // this is our custom ActionMethod 
        //http://localhost:56808/MyTest/WhatsName --- this is the call from browser
        public string whatsName()
        {
            return "my name is satyam";
        }

        // GET input from browser
        // http://localhost:56808/MyTest/StudentRank?rank=2  this is URL to hit here 
        // can handel null :-> int? rank  <-:
        public string StudentRank(int? rank)
        {
           if(rank == 1)
            {
                return $"Student got rank {rank} good";
            }
           else if(rank == 2)
            {
                return $"Student got rank {rank} do some study";
            }
            else
            {
                return  $"Student got rank {rank} need hard study";
            }
        }

        // http://localhost:56808/MyTest/StudentName?lname=bidve&fname=satyaam    working fine HomeWork
        public string StudentName(string fName , string lName)
        {
            if (fName == null)
            {
                return $"Your last name is  = {lName}";
            }
            else if (lName == null) 
                {
                return $"Your first name is  = {fName}";
            }
            else
            {
                return $"Your first name is  = {fName} and last name is = {lName}";
            }

        }
    }
}