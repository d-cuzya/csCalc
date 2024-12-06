using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string task = "83 + 9 * (6 /3)";
            string tmp = "";
            List<int> objects = new List<int>();
            for(UInt16 i = 0; i < task.Length; i++)
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
            Console.WriteLine(task);
            for (int i = 0; i < objects.Count; i++)
            {
                Console.WriteLine(objects[i]);
            }
        }
    }
}