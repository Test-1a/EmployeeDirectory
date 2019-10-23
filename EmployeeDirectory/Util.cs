using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDirectory
{
    public static class Util
    {
        internal static string AskForString(string prompt)
        {
            bool correct = true;
            string answer;

            do
            {
                Console.WriteLine(prompt);
                answer = Console.ReadLine();
                
                if (!string.IsNullOrEmpty(answer))
                {
                    correct = false;
                }

            } while (correct);

            return answer;
        }

        internal static int AskForInt(string prompt)
        {
            bool success = false;
            int answer;

            do
            {
                string input = AskForString(prompt);

                success = int.TryParse(input, out answer);
                if (!success)
                {
                    Console.WriteLine("Wrong format only numbers");
                }

            } while (!success);

            return answer;
        }
    }
}
