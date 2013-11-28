using System;

namespace Tester
{
	using MigrationsDoneRight;
	using MigrationsDoneRight.SqlImplementation;

	class Program
	{
		static void Main(string[] args)
		{
			var migrationInterpreter = new SqlMigrationInterpreter();
			IFluentMigration exampleMigration = new ExampleMigration();

			Console.WriteLine(migrationInterpreter.GetSql(exampleMigration));
		}
	}
}
