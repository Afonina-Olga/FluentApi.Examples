namespace FluentApi.SOLID
{
	/// <summary>
	/// IControlFlowScheduler<> is responsible for Initializing and Executing the control flow steps. This is a generic interface that only works with IControlFlowStep types. 
	/// </summary>
	/// <typeparam name="TControllableStep"></typeparam>
	public interface IControlFlowScheduler<TControllableStep> where TControllableStep: IControlFlowStep
	{
		/// <summary>
		/// Readies the control flow scheduler for sequence definition
		/// </summary>
		IControlFlowStepThenDoer<TControllableStep> Initialize();

		/// <summary>
		/// Executes the currently defined sequence
		/// </summary>
		void Execute();
	}
}
