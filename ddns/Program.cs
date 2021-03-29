using System;

namespace ddns
{
	class Program
	{
		static void Main(string[] args)
        {
            string LastIPFilePath = Environment.GetEnvironmentVariable(nameof(LastIPFilePath));
            string LogIPFilePath = Environment.GetEnvironmentVariable(nameof(LogIPFilePath));
            string RawIPSource = Environment.GetEnvironmentVariable(nameof(RawIPSource));
        }
	}
}
