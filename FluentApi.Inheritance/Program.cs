namespace FluentApi.Inheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			var customer = new FluentCustomer()
				.WithAccountNumber("13")
				.WithFirstName("firstName")
				.WithLastName("lastName");
		}
	}
}
