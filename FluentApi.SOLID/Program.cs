using System;

namespace FluentApi.SOLID
{
	/// <summary>
	/// https://saharsh-sinha-career.medium.com/writing-clean-facades-using-a-fluent-api-in-c-6a779a64f0e9
	/// </summary>
	class Program
	{
		private static readonly IControlFlowScheduler<IDailyTask> _dailyScheduler;

		static void Main(string[] args)
		{
			_dailyScheduler
				.Initialize()
				.Then()
				.Do<MyTask>()
				.Then()
				.Do<MyNewTask>()
				.Then()
				.Do<MyTask>();
		}
	}
}
