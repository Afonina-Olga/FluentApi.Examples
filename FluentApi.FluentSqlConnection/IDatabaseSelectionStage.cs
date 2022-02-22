namespace FluentApi.FluentSqlConnection
{
	public interface IDatabaseSelectionStage
	{
		IUserSelectionStage AndDatabase(string database);
	}
}
