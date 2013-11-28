namespace MigrationsDoneRight.Syntax
{
	public interface IColumnConfigurator
	{
		IColumnConfigurator HasType(string type);

		IColumnConfigurator IsPrimaryKey();
	}
}