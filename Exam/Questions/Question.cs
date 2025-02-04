using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Questions
{
    public class Question
    {
       
        public string Header { get; set; }

       
        public string Body { get; set; }

        
        public int Marks { get; set; }

        
        public Question(string header, string body, int marks)
        {
            Header = header;
            Body = body;
            Marks = marks;
        }

   
        public override string ToString()
        {
            return $"{Header}\n{Body}\nMarks: {Marks}";
        }
    }
}
