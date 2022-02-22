using System;
using System.Threading;
using System.Threading.Tasks;

namespace FluentApi.SOLID
{
	public class MyNewTask : IDailyTask
	{
		public void Execute()
		{
			throw new NotImplementedException();
		}

		public Task ExecuteAsync(CancellationToken cancellationToken = default)
		{
			throw new NotImplementedException();
		}

		public void Test()
		{
			throw new NotImplementedException();
		}
	}
}
