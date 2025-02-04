using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.exams
{
    public class FinalExam : Exam
    {
        #region constructor

        public FinalExam(DateTime examTime, int numberOfQuestions, Subject subject)
            : base(examTime, numberOfQuestions, subject) { }
        #endregion

        #region method
        public override void ShowExam()
        {
            Console.WriteLine("Displaying Final Exam Questions and Grades.");
        } 
        #endregion
    }
}
