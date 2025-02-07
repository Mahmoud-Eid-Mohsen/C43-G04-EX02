using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Questions
{
    public class MCQQuestion : Question

    {
        #region constructor
        public MCQQuestion(string body, int marks)
        : base(body, marks) { }

        #endregion
        public override void Display()
        {
            Console.WriteLine($"MCQ Question: {Body}");
            for (int i = 0; i < AnswerList.Length; i++)
            {
                Console.WriteLine($"{AnswerList[i].AnswerId} - {AnswerList[i].AnswerText}");
            }
        }
    }
}
