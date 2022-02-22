using System;
using System.Data;

namespace FluentApi.FluentSqlConnection
{
	public class FluentSqlConnection : 
		IConnectionInitializerStage, 
		IDatabaseSelectionStage, 
		IPasswordSelectionStage, 
		IServerSelectionStage, 
		IUserSelectionStage
	{
		private string _server;
		private string _database;
		private string _user;
		private string _password;

		private FluentSqlConnection() { }

		public static FluentSqlConnection CreateConnection(Action<ConnectionConfiguration> config)
		{
			var configuration = new ConnectionConfiguration();
			config?.Invoke(configuration);
			return new FluentSqlConnection();
		}

		public IUserSelectionStage AndDatabase(string database)
		{
			_database = database;
			return this;
		}

		public IPasswordSelectionStage AsUser(string user)
		{
			_user = user;
			return this;
		}

		public IDbConnection Connect()
		{
			throw new NotImplementedException();
		}

		public IDatabaseSelectionStage ForServer(string server)
		{
			_server = server;
			return this;
		}

		public IConnectionInitializerStage WithPassword(string password)
		{
			_password = password;
			return this;
		}
	}
}
