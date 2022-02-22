namespace FluentApi.RecursiveGenerics
{
	public class EmployeePositionBuilder : EmployeeInfoBuilder
	{
		public EmployeePositionBuilder AtPosition(string position)
		{
			employee.Position = position;
			return this;
		}
	}

	public class EmployeePositionBuilder<T> : EmployeeInfoBuilder<EmployeePositionBuilder<T>> where T : EmployeePositionBuilder<T>
	{
		public T AtPosition(string position)
		{
			employee.Position = position;
			return (T)this;
		}
	}
}
