namespace FluentApi.RecursiveGenerics
{
	public class EmployeeInfoBuilder
	{
		protected Employee employee = new Employee();

		public EmployeeInfoBuilder SetName(string name)
		{
			employee.Name = name;
			return this;
		}
	}

	public class EmployeeInfoBuilder<T> : EmployeeBuilder where T : EmployeeInfoBuilder<T>
	{
		public T SetName(string name)
		{
			employee.Name = name;
			return (T)this;
		}
	}
}
