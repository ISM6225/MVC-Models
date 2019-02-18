/*
    Author: Clinton Daniel
    Date: 2/18/2019
    Comments: This application is designed to help a developer learn
              how models work in the MVC context within the ASP.NET Core.
    Reference: This example is adapted from examples in the following text
    :
        Adam Freeman, "Pro ASP.NET Core MVC", Seventh Edition, 2017, Appress.
*/

using System;
using Microsoft.AspNetCore.Mvc;
using MVC_Models.Models;
using System.Linq;

namespace MVC_Models.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView");
        }
        // This HttpGet attribute added to the RsvpForm action method
        // tels MVC that this method should be used only for GET requests
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        //This HttpPost attribute added to the  RsvpForm action model
        // tells MVC that this overloaded RsvpForm method will use POST requests
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            // Access the Repository class to get the GuestResponse
            // The GuestResponse object is passed to the action method
            // Using the AddResponse method, the response data will be stored
            // in memory. 
            Repository.AddResponse(guestResponse);
            return View("Thanks", guestResponse);
        }
        // ListResponse action method is used when the user wants to 
        // render the view that displays all of the responses. 
        /*
           Here, the ListResponse action method calls the View method the
           using Repository.Reponses property as the argument. This is how 
           an action method provides data to a strongly typed view. The
           collection of GuestResponse objects is filtered using LINQ so
           that only positive responses are used. 
        */
        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }
}
