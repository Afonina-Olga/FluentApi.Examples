namespace FluentApi.FluentSqlConnection
{
	public interface IUserSelectionStage
	{
		IPasswordSelectionStage AsUser(string user);
	}
}