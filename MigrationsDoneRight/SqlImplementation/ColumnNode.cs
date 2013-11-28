namespace MigrationsDoneRight.SqlImplementation
{
	using MigrationsDoneRight.Syntax;

	public class ColumnNode:ISqlNode
	{
		private readonly string _name;

		public ColumnNode(string name)
		{
			_name = name;
			Configurator = new ColumnConfigurator(this);
		}

		public IColumnConfigurator Configurator { get; private set; }

		public string GetSql()
		{
			return string.Format("{0} {1} {2}", _name, Type, IsPrimaryKey ? "primary key" : "");
		}

		private class ColumnConfigurator:IColumnConfigurator
		{
			private readonly ColumnNode _columnNode;

			public ColumnConfigurator(ColumnNode columnNode)
			{
				_columnNode = columnNode;
			}

			public IColumnConfigurator HasType(string type)
			{
				_columnNode.Type = type;
				return this;
			}

			public IColumnConfigurator IsPrimaryKey()
			{
				_columnNode.IsPrimaryKey = true;
				return this;
			}
		}

		private bool IsPrimaryKey { get; set; }

		private string Type { get; set; }
	}
}