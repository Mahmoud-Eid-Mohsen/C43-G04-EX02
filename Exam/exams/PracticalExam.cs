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
        public PracticalExam(int duration, int numberOfQuestions)
          : base(duration, numberOfQuestions) { }


        #endregion

        #region method
        public override void ShowExam()
        {
            Console.WriteLine($"Practical Exam: Duration {Duration} minutes, Questions: {NumberOfQuestions}");
        }

        public override void StartExam()
        {
            Console.WriteLine("Do you want to Start Practical Exam (Y/N)?");
            char start = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (start == 'Y')
            {
                for (int i = 0; i < Questions.Count; i++)
                {
                    Questions[i].Display();
                    Console.Write("Please Enter The answer Id: ");
                    int answerId = int.Parse(Console.ReadLine());

                    if (Questions[i].CorrectAnswer.AnswerId == answerId)
                    {
                        TotalMarks += Questions[i].Marks;
                    }
                }

                Console.WriteLine($"Your Grade is: {TotalMarks} out of {NumberOfQuestions * 3}");
            }
            else
            {
                Console.WriteLine("Practical Exam not started.");
            }
        }
        #endregion

    }
}
