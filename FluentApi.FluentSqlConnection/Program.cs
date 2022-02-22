namespace FluentApi.FluentSqlConnection
{
	class Program
	{
		static void Main(string[] args)
		{
			FluentSqlConnection
				.CreateConnection(config =>
				{
					config.ConnectionName = "name";
				})
				.AndDatabase("name")
				.AsUser("user")
				.WithPassword("pass")
				.Connect();
		}
	}
}
