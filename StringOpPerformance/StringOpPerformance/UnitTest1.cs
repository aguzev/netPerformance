using System;
using System.Text;
using Xunit;

namespace StringOpPerformance
{
    public class UnitTest1
    {
        private const int IterationLimit = 100000;

        [Fact]
        public void StringBuilderAppend()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < IterationLimit; i++)
            {
                sb.Append("\r\n('")
                    .Append(i).Append("','")
                    .Append(i+1).Append("','")
                    .Append(i+2).Append("','")
                    .Append(i+3).Append("','")
                    .Append(i+4).Append("','")
                    .Append(i+5).Append("','")
                    .Append(i+6).Append("','")
                    .Append(i+7).Append("','")
                    .Append(i+8).Append("','")
                    .Append(i+9)
                    .Append("'),");
            }

            sb.Length -= 1;
            var output = sb.ToString();

            Assert.NotNull(output);
        }

        [Fact]
        public void StringInterpolation()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < IterationLimit; i++)
            {
                sb.Append(
                    $"\r\n('{i}','{i + 1}','{i + 2}','{i + 3}','{i + 4}','{i + 5}','{i + 6}','{i + 7}','{i + 8}','{i + 9}'),");
            }

            sb.Length -= 1;
            var output = sb.ToString();

            Assert.NotNull(output);
        }

        

        [Fact]
        public void StringBuilderAppendFormat()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < IterationLimit; i++)
            {
                sb.AppendFormat(
                    "\r\n('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}'),",
                    i, i + 1, i + 2, i + 3, i + 4, i + 5, i + 6, i + 7, i + 8, i + 9);
            }

            sb.Length -= 1;
            var output = sb.ToString();

            Assert.NotNull(output);
        }
    }
}
