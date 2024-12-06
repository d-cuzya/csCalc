using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string task = "83 + 9 * 6 /31 - 10"; //res = 74,74..
            string tmp = "";
            List<int> objects = new List<int>();
            List<char> tasks = new List<char>();
            for (UInt16 i = 0; i < task.Length; i++)
            {
                if (task[i] != ' ')
                {
                    tmp += task[i];
                }
            }
            task = tmp;
            tmp = "";
            for (UInt16 i = 0; i < task.Length; i++)
            {
                if (char.IsDigit(task[i]))
                {
                    tmp += task[i];
                }
                else
                {
                    if (tmp != "")
                    {
                        objects.Add(Convert.ToInt32(tmp));
                        tmp = "";
                    }
                }
            }
            for (UInt16 i = 0; i < task.Length; i++)
            {
                if (new char[] {'+', '-', '*', '/' }.Contains(task[i])) {
                    tasks.Add(task[i]);
                }
            }
            //DEBUG Output
            for (int i = 0; i < objects.Count; i++)
            {
                Console.WriteLine(objects[i]);
            }
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine(tasks[i]);
            }
            // Core task
            double res = 0;
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i] == '*')
                {
                    res += objects[i] * objects[i + 1];
                }
                // Add other tassk
                // Add priority
            }
        }
    }
}