using Exam.exams;
using Exam.mainfunction;
using Exam.Questions;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            int mainChoice;


            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Examination System");
                Console.WriteLine("-------------------------------------------\n");

                Console.WriteLine("Please choose a type of exam:");
                Console.WriteLine("1. Final Exam | 2. Practical Exam | 3. Exit");
                Console.Write("Choose an option: ");
            } while (!int.TryParse(Console.ReadLine(), out mainChoice) || (mainChoice < 1 || mainChoice > 3));
            Console.Clear();

            if (mainChoice == 1)
            {
                ExamManager.CreateFinalExam();
            }
            else if (mainChoice == 2)
            {
               ExamManager.CreateFinalExam();
            }
            else if (mainChoice == 3)
            {
                Console.WriteLine("Exiting the program. Thank you!");
                Console.ReadKey(); 
                return;
            }




            
        }
    }
}
