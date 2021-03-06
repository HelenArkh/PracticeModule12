using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeModule12
{
    public class Testing
    {
		static int Iterations = 10000;
		[Benchmark]
		public string UseString()
		{
			string value = "";

			for (int i = 0; i < Iterations; i++)
			{
				value += i.ToString();
				value += " ";
			}

			return value;
		}

		[Benchmark]
		public string UseStringBuilder()
		{
			StringBuilder builder = new StringBuilder();

			for (int i = 0; i < Iterations; i++)
			{
				builder.Append(i.ToString());
				builder.Append(" ");
			}

			return builder.ToString();
		}
	}
}
