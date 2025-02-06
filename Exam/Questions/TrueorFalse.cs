using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Questions
{
    public class TrueOrFalseQuestion : Question
    {
        #region constructor
        public TrueOrFalseQuestion(string body, int marks)
         : base(body, marks) { }
        #endregion
        #region method
        public override void Display()
        {
            Console.WriteLine($"True | False Question: {Body}");
            Console.WriteLine("1 - True | 2 - False");
        }

        #endregion

    }
}
