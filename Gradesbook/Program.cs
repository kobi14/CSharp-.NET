using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Gradesbook
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("hello,kobi ");
            Grade book = new Grade();
            book.AddGrade(78);
            book.AddGrade(93.9f);
            book.AddGrade(66);
           

            //foreach(var i in book.Printx())
            //{
            //    Console.WriteLine(i);
            //}

            GradeSataistics stats = book.ComputeStatistics();

            Console.WriteLine(stats.AvarageGrade);
            Console.WriteLine(stats.highestGrade);
            Console.WriteLine(stats.lowestGrade);

            Console.WriteLine(stats);

            Console.ReadLine();
        }
    }
}
