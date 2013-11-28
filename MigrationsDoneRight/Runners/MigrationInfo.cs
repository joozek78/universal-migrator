namespace MigrationsDoneRight.Runners
{
	public sealed class MigrationInfo<TMigration>
	{
		public MigrationInfo(TMigration migration, long id)
		{
			Id = id;
			Migration = migration;
		}

		public long Id { get; private set; }
		public TMigration Migration { get; private set; }
	}
}