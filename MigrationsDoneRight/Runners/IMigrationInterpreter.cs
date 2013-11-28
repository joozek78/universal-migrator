namespace MigrationsDoneRight.Runners
{
	public interface IMigrationInterpreter<in TMigration>
	{
		string GetSql(TMigration migration);
	}
}