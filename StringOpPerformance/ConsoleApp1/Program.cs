using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        private static readonly string[] Data = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"};

        static void Main(string[] args)
        {
            const int roundLimit = 100;
            const int iterationLimit = 400000;
            string output;

            for (int i = 0; i < roundLimit; i++)
            {
                // output = StringBuilderAppendFormat(iterationLimit);
                output = StringBuilderAppend(iterationLimit);
                output = StringInterpolation(iterationLimit);
            }
        }

        public static string StringBuilderAppend(int iterationLimit)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < iterationLimit; i++)
            {
                sb.Append("\r\n('")
                    .Append(Data[0]).Append("','")
                    .Append(Data[1]).Append("','")
                    .Append(Data[2]).Append("','")
                    .Append(Data[3]).Append("','")
                    .Append(Data[4]).Append("','")
                    .Append(Data[5]).Append("','")
                    .Append(Data[6]).Append("','")
                    .Append(Data[7]).Append("','")
                    .Append(Data[8]).Append("','")
                    .Append(Data[9])
                    .Append("'),");
            }

            sb.Length -= 1;
            return sb.ToString();
        }

        public static string StringInterpolation(int iterationLimit)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < iterationLimit; i++)
            {
                sb.Append(
                    $"\r\n('{Data[0]}','{Data[1]}','{Data[2]}','{Data[3]}','{Data[4]}','{Data[5]}','{Data[6]}','{Data[7]}','{Data[8]}','{Data[9]}'),");
            }

            sb.Length -= 1;
            return sb.ToString();
        }

        public static string StringBuilderAppendFormat(int iterationLimit)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < iterationLimit; i++)
            {
                sb.AppendFormat(
                    "\r\n('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}'),",
                    Data[0], Data[1], Data[2], Data[3], Data[4], Data[5], Data[6], Data[7], Data[8], Data[9]);
            }

            sb.Length -= 1;
            return sb.ToString();
        }
    }
}
