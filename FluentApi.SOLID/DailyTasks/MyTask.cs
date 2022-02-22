using System;
using System.Threading;
using System.Threading.Tasks;

namespace FluentApi.SOLID
{
	public class MyTask : IDailyTask
	{
		public void Execute()
		{
			Console.WriteLine("Execute");
		}

		public Task ExecuteAsync(CancellationToken cancellationToken = default)
		{
			return Task.Run(() => Console.WriteLine("Execute async"));
		}

		public void Test()
		{
			Console.WriteLine("Test");
		}
	}
}
