namespace FluentApi.FluentSqlConnection
{
	public interface IPasswordSelectionStage
	{
		IConnectionInitializerStage WithPassword(string password);
	}
}
