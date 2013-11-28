namespace MigrationsDoneRight
{
	public class ExampleMigration:IFluentMigration
    {
	    public void Up(IMigrationBuilder migrationBuilder)
	    {
		    var patient = migrationBuilder.CreateTable("patient")
			    .InSchema("adt");
		    patient.AddColumn("id")
				.HasType("int")
				.IsPrimaryKey();
			patient.AddColumn("name")
				.HasType("text");
	    }
    }
}
