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

            // TODO - implement fizz buzz logic.

            // add all numbers from 1 to 100 to the model.Numbers.

            // if the number is divisible by 3, print fizz.
            // if the number is divisible by 5, print buzz.
            // if the number is divisible by 3 and 5, print fizzbuzz.

            for (var i = 1; i <= 100; i++)
            {
                model.Output.Add(i.ToString());
            }



            return View(model);
        }

    }
}
