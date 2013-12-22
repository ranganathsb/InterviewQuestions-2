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

            for (var i = 1; i <= 100; i++)
            {
                // TODO - implement fizz buzz logic.
                // if the number is divisible by 3, print fizz.
                // if the number is divisible by 5, print buzz.
                // if the number is divisible by 3 and 5, print fizzbuzz.

                model.Output.Add(i.ToString());
            }



            return View(model);
        }

    }
}
