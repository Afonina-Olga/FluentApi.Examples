using System.Threading;
using System.Threading.Tasks;

namespace FluentApi.SOLID
{
	/// <summary>
	/// IControlFlowStep is the base interface for any Step that will be executed within the facade (e.g. TheSchool).
	/// </summary>
	public interface IControlFlowStep
	{
		/// <summary>
		/// Contains code to synchronously execute step
		/// </summary>
		void Execute();

		/// <summary>
		/// Contains code to asynchronously execute code
		/// </summary>
		Task ExecuteAsync(CancellationToken cancellationToken = default(CancellationToken));
	}
}
