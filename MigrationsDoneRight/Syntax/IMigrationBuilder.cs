namespace MigrationsDoneRight
{
	using MigrationsDoneRight.Syntax;

	public interface IMigrationBuilder
	{
		ICreateTableSyntax CreateTable(string name);
	}
}