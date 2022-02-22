using System.Data;

namespace FluentApi.FluentSqlConnection
{
	public interface IConnectionInitializerStage
	{
		IDbConnection Connect();
	}
}
