using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewQuestions.Models
{
    public class FizzBuzzVM
    {
        public FizzBuzzVM()
        {
            Numbers = new List<int>();
        }

        public List<int> Numbers { get; set; }
    }
}