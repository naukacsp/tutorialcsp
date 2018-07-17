using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hello internee! You are doing quite well! ");
            */
            GradeBook book = new GradeBook();
            /* to invoke both methods */
            book.NameChanged = new NameChangedDelegate(OnNameChanged);
            book.NameChanged += OnNameChanged;
            // overwrite code above: book.NameChanged = new NameChangedDelegate(OnNameChanged2);
            book.Name = "Scott's Grade Book";
            book.Name = "Grade Book";
            book.Name = "";

            book.AddGrade(91);
            book.AddGrade(89.5f); //as a float
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest:", (int)stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            /*
            Console.WriteLine("The average of grades is:" + stats.AverageGrade);
            Console.WriteLine("The highest grade is:" + stats.HighestGrade);
            Console.WriteLine("The lowest grades is:" + stats.LowestGrade);
            */
            Console.ReadKey();
            /*
            GradeBook book2 = book;
            book2.AddGrade(75);
            */
        }

        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }

        private static void WriteResult(string description, float result)
        {
            Console.WriteLine(description + ": " + result);
        }

        private static void WriteResult(string description, int result)
        {
            Console.WriteLine("{0}: {1:F2}", description, result);
            Console.WriteLine($"{description}: {result:F2}");
        }
    }
}