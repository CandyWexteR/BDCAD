using System;
using Microsoft.VisualBasic.Devices;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Core;
using KompasWrapper;

namespace StressTesting
{
	class Program
	{
		static void Main(string[] args)
		{
			var builder = new TableBuilder();
			var stopWatch = new Stopwatch();
			stopWatch.Start();
			var tableParameters = new TableParameters();
			var streamWriter = new StreamWriter("log.txt", true);
			var count = 0;
			while (true)
			{
					builder.Build(tableParameters);
					var computerInfo = new ComputerInfo();
					var usedMemory = (computerInfo.TotalPhysicalMemory - computerInfo.AvailablePhysicalMemory) *
					                 0.000000000931322574615478515625;
					streamWriter.WriteLine(
						$"{++count}\t{stopWatch.Elapsed:hh\\:mm\\:ss}\t{usedMemory}");
					streamWriter.Flush();
					Task.Delay(TimeSpan.FromMilliseconds(10));
			}
		}
	}
}
