using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InterviewQuestions.Models;

namespace InterviewQuestions.Controllers
{
    public class InterviewController : Controller
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


        public ActionResult Question2()
        {
            var model = new TreeDataVM();

            var trees = getTreeData();
            var types = getTreeTypes();

            //TODO - set the following properties correctly.
            model.AveragePrice = 0M;
            model.FirCount = 0;

            return View(model);

        }

        private List<Tree> getTreeData() {
            return new List<Tree>
            {
                new Tree{Id=1, TreeType=1, Height=6.5M, Price=40},
                new Tree{Id=2, TreeType=2, Height=6.5M, Price=45},
                new Tree{Id=3, TreeType=3, Height=6M, Price=40},
                new Tree{Id=4, TreeType=3, Height=7M, Price=60},
                new Tree{Id=5, TreeType=3, Height=6.5M, Price=50},
                new Tree{Id=6, TreeType=2, Height=7.5M, Price=60},
                new Tree{Id=7, TreeType=1, Height=6M, Price=55},
                new Tree{Id=8, TreeType=1, Height=5.5M, Price=40},
                new Tree{Id=9, TreeType=1, Height=5.5M, Price=35},
            };
        }

        private List<TreeType> getTreeTypes()
        {
            return new List<TreeType> {
                new TreeType{ Id=1, Description="Fir"},
                new TreeType{ Id=2, Description="Balsam"},
                new TreeType{ Id=3, Description="Douglas"}
            };
        }

        private class Tree
        {
            public int Id { get; set; }
            public int TreeType { get; set; }
            public decimal Height { get; set; }
            public decimal Price { get; set; }
        }

        private class TreeType
        {
            public int Id { get; set; }
            public string Description { get; set; }

        }
    }
}
