namespace MigrationsDoneRight.Syntax
{
	public interface ICreateTableSyntax
	{
		ICreateTableSyntax InSchema(string name);
		IColumnConfigurator AddColumn(string name);
	}
}