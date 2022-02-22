namespace FluentApi.Inheritance
{
	public class FluentCustomer : FluentPerson<FluentCustomer>
	{
		public FluentCustomer WithAccountNumber(string accountNumber)
		{
			// ...
			return this;
		}
	}
}
