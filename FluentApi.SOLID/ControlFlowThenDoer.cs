using System;
using System.Collections.Generic;

namespace FluentApi.SOLID
{
	public class ControlFlowThenDoer<TControllableStep> :
		ControlFlowDoer<TControllableStep>,
		IControlFlowStepThenDoer<TControllableStep>
		where TControllableStep : IControlFlowStep
	{
		public ControlFlowThenDoer()
		{
			_controlFlowThenDoer = this;
		}
		public IControlFlowDoer<TControllableStep> Then()
		{
			_mostRecentCollectionOfConcurrentSteps = new List<Type>();
			_sequenceOfGroupsOfStepsToExecute.Add(_mostRecentCollectionOfConcurrentSteps);
			return this;
		}
	}
}