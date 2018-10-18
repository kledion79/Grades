using System;

namespace Grades
{
    internal class Program
    {
        public static void Main(string[] args)
        {

          
            GradeBook book = new GradeBook();
            book.NameChanged += new NameChangedDelegate(OnNameChanged);
            // or book.NameChanged += OnNameChanged; --> is the same
            book.NameChanged += OnNameChanged;
            //.NameChanged += new NameChangedDelegate(OnNameChanged2);
            // does not allow book.NameChanged = null; --> because we assigned it as an event instead of as a delegate
           
            book.Name = "Kley";
            book.Name = "John's book";
            book.Name = "Peter's book";
            Console.WriteLine(book.Name);
            
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
            
            GradeStatistics stats = book.ComputeStatistics();
           WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            
            Console.ReadLine();
       

        }

        static void OnNameChanged(object sender, NameChangedEventsArgs args)
        {
            Console.WriteLine($"Grade boook changing name from {args.ExistingName} to {args.NewName}", args.ExistingName, args.NewName);
            
        }
        //not used
       
        //helper method    
        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result}", description, result);
        }
    }
}