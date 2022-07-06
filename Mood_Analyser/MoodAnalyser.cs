using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Mood_Analyser
{
   public class MoodAnalyser
    {
        public string message;

        public MoodAnalyser(string msg)
        {
            this.message = msg;
        }
        public string AnalyseMood(string msg)
        {
            //message = Console.ReadLine();
            if (msg.Length > 0)
            {
                message = msg;
            }
            if (message.Contains("happy", StringComparison.OrdinalIgnoreCase))
            {
                return "happy";
            }
            if (message.Contains("sad", StringComparison.OrdinalIgnoreCase))
            {
                return "sad";
            }

            return null;
        }
        public void  AnalyseAnyMood(string msg)
        {
            //message = Console.ReadLine();
            if (msg.Length > 0)
            {
                message = msg;
            }
                       
            if (message.Contains("sad", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("sad");
            }
            else
            {
                Console.WriteLine("happy");
            }
        }

   }
}

