namespace MigrationsDoneRight.SqlImplementation
{
	using MigrationsDoneRight.Runners;

	public class SqlMigrationInterpreter : IMigrationInterpreter<IFluentMigration>
	{
		public string GetSql(IFluentMigration migration)
		{
			var builder = new SqlMigrationBuilder();
			migration.Up(builder);

			return builder.GetSql();
		}
	}
}