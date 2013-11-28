namespace MigrationsDoneRight
{
	public interface IFluentMigration
	{
		void Up(IMigrationBuilder builder);
	}
}