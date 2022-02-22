namespace FluentApi.RecursiveGenerics
{
	public class EmployeeBuilderDirector : EmployeeSalaryBuilder<EmployeeBuilderDirector>
	{
		public static EmployeeBuilderDirector NewEmployee => new EmployeeBuilderDirector();
	}
}
