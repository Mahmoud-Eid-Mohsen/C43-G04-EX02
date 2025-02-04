using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.exams
{
    public abstract class Exam
    {
        #region property
        public DateTime ExamTime { get; set; }
        public int NumberOfQuestions { get; set; }
        public Subject Subject { get; set; }

        #endregion
        #region constructor
        protected Exam(DateTime examTime, int numberOfQuestions, Subject subject)
        {
            ExamTime = examTime;
            NumberOfQuestions = numberOfQuestions;
            Subject = subject;
        }
        #endregion

        #region method
        public abstract void ShowExam(); 
        #endregion
    }
}
