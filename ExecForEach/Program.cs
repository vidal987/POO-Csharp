using System;

namespace ExecForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "maria", "alex", "teta" };

            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }

            foreach (var obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
