using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InterviewQuestions.Models;

namespace InterviewQuestions.Controllers
{
    public class FizzBuzzController : Controller
    {
        //
        // GET: /FizzBuzz/

        public ActionResult Question1()
        {
            var model = new FizzBuzzVM();

            model.Numbers.Add(1);


            return View(model);
        }

    }
}
