using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentApi.SOLID
{
	public class ControlFlowScheduler<TControllableStep> : IControlFlowScheduler<TControllableStep>
		where TControllableStep : IControlFlowStep
	{
		private readonly Func<IControlFlowStepThenDoer<TControllableStep>> _controlFlowStepThenDoerFactory;
		private IControlFlowStepThenDoer<TControllableStep> _controlFlowStepThenDoer;
		private IDictionary<Type, IControlFlowStep> _controllableStepsDictionary;

		public ControlFlowScheduler(
			Func<IControlFlowStepThenDoer<TControllableStep>> controlFlowStepThenDoerFactory,
			IEnumerable<TControllableStep> controllableSteps)
		{
			_controlFlowStepThenDoerFactory = controlFlowStepThenDoerFactory;
			_controllableStepsDictionary = new Dictionary<Type, IControlFlowStep>();

			foreach (var controllableStep in controllableSteps)
			{
				_controllableStepsDictionary.Add(controllableStep.GetType(), controllableStep);
			}
		}

		public void Execute()
		{
			foreach (IReadOnlyCollection<Type> groupsOfStepsToExecute in ((ControlFlowDoer<TControllableStep>)(_controllableStepsDictionary))._sequenceOfGroupsOfStepsToExecute)
			{
				ExecuteSteps(groupsOfStepsToExecute);
			}
		}

		public IControlFlowStepThenDoer<TControllableStep> Initialize()
		{
			throw new NotImplementedException();
		}

		private void ExecuteSteps(IEnumerable<Type> types)
		{
			if (types.Count() == 1)
				_controllableStepsDictionary[types.First()].Execute();
			else
				Parallel.ForEach(
					types,
					async (type) =>
					{
						IControlFlowStep aConcurrentStep = _controllableStepsDictionary[type];
						await aConcurrentStep.ExecuteAsync();
					});
		}
	}
}
