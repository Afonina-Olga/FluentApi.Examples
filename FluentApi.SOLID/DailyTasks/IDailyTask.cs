namespace FluentApi.SOLID
{
	/// <summary>
	/// Serves as a specific interface for proper configuration
	/// with DI Containers and compile time safety
	/// </summary>
	public interface IDailyTask : IControlFlowStep
	{
		void Test();
	}
}
