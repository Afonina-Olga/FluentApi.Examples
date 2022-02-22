using System;
using System.Collections.Generic;

namespace FluentApi.SOLID
{
	public class ControlFlowDoer<TControllableStep> : IControlFlowDoer<TControllableStep>
		where TControllableStep : IControlFlowStep
	{
		private IControlFlowStepThenDoer<TControllableStep> _controlFlowStepThenDoer => _controlFlowStepThenDoer;
		private protected ControlFlowThenDoer<TControllableStep> _controlFlowThenDoer;
		internal protected List<Type> _mostRecentCollectionOfConcurrentSteps;
		internal protected List<List<Type>> _sequenceOfGroupsOfStepsToExecute = new List<List<Type>>();

		public IControlFlowStepThenDoer<TControllableStep> Do<TControllableStepAlias>() where TControllableStepAlias : TControllableStep
		{
			_mostRecentCollectionOfConcurrentSteps.Add(typeof(TControllableStepAlias));
			return _controlFlowStepThenDoer;
		}
	}
}
