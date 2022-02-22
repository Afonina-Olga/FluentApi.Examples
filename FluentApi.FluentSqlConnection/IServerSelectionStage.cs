namespace FluentApi.FluentSqlConnection
{
	public interface IServerSelectionStage
	{
		IDatabaseSelectionStage ForServer(string server);
	}
}
