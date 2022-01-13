using System;
using System.Collections.Generic;

namespace baseBallScoreCalculate
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ops = Console.ReadLine().Split(" ");

            int output = CalPoints(ops);

            

            Console.WriteLine(output);


        }

        private static int CalPoints(string[] ops)
        {

            List<int> scoreList = new List<int>();
            int sum = 0;

            for (int i = 0; i < ops.Length-1; i++)
            {

                if(ops[i]=="C")
                {
                    scoreList.Remove(int.Parse(ops[i - 1]));
                }
                else if (ops[i] == "D")
                {
                    var dScore = Convert.ToInt32(ops[i]) * 2;
                    scoreList.Add(dScore);
                }
                else if (ops[i] == "+")
                {
                    var newScore = int.Parse(ops[i]) + int.Parse(ops[i - 1]);
                    scoreList.Add(newScore);
                }
                else
                {
                    scoreList.Add(Convert.ToInt32(ops[i]));
                }
                

            }

            foreach (var item in scoreList)
            {
                sum += item;
            }

            return sum;
        }
    }
}
