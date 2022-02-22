using System;

namespace FluentApi.RecursiveGenerics
{
	class Program
	{
		static void Main(string[] args)
		{
			var emp = EmployeeBuilderDirector
				.NewEmployee
				.SetName("Name")
				.AtPosition("position")
				.WithSalary(3500)
				.Build();
		}
	}
}
