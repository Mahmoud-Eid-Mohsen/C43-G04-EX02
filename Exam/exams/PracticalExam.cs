using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.exams
{
    public class PracticalExam : Exam
    {
        #region constructor
        public PracticalExam(DateTime examTime, int numberOfQuestions, Subject subject)
            : base(examTime, numberOfQuestions, subject) { }
        #endregion

        #region method
        public override void ShowExam()
        {
            Console.WriteLine("Displaying Practical Exam Questions and the right answers.");
        } 
        #endregion

    }
}
