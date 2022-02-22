namespace FluentApi.SOLID
{
	/// <summary>
	/// Provides functionality to schedule execution of a control flow step
	/// </summary>
	public interface IControlFlowDoer<TControllableStep>
		where TControllableStep : IControlFlowStep
	{
		IControlFlowStepThenDoer<TControllableStep> Do<TControllableStepAlias>()
			where TControllableStepAlias : TControllableStep;
	}
}
