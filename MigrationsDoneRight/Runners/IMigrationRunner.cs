namespace MigrationsDoneRight.Runners
{
	using System.Collections.Generic;

	public interface IMigrationRunner<TMigration>
	{
		void UpdateToLatest(
			string connectionString,
			IMigrationInterpreter<TMigration> migrationInterpreter,
			IEnumerable<MigrationInfo<TMigration>> migrations);
	}
}