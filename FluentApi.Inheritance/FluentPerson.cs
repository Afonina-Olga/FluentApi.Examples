namespace FluentApi.Inheritance
{
	public class FluentPerson<T> where T : FluentPerson<T>
	{
		public T WithFirstName(string firstName)
		{
			// ...
			return (T)this;
		}

		public T WithLastName(string lastName)
		{
			// ...
			return (T)this;
		}
	}
}
