namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Examination System");
            Console.WriteLine("-------------------------------------------\n");
            int mainChoice;


            do
            {
                Console.WriteLine("Please choose a type of exam:");
                

                Console.WriteLine("1. Final Exam | 2. Practical Exam  | 3. Exisit");
               
                Console.Write("Choose an option: ");
            }
            while (!int.TryParse(Console.ReadLine(), out mainChoice) || (mainChoice != 1 && mainChoice != 2&& mainChoice != 3));


            Console.Clear();
          
            Console.ReadKey();
        }
    }
}
