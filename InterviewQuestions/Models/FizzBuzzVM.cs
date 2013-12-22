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
            Output = new List<string>();
        }

        public List<string> Output { get; set; }
    }
}