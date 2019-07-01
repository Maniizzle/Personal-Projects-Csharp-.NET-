using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RSVP.Models;

namespace RSVP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("MyView");
        }
        [HttpGet]
        public IActionResult RSVPForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RSVPForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {//there is a validation error
                return View();
            }
        }
        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == false));
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
    //
}
