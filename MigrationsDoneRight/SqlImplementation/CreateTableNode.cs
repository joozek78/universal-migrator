namespace MigrationsDoneRight
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using MigrationsDoneRight.Commons;
	using MigrationsDoneRight.SqlImplementation;
	using MigrationsDoneRight.Syntax;

	public class CreateTableNode : ISqlNode
	{
		private readonly string _name;
		private readonly List<ColumnNode> _columnNodes;
		private string _schema;

		public CreateTableNode(string name)
		{
			_name = name;
			_columnNodes = new List<ColumnNode>();
		}

		public ICreateTableSyntax GetSyntax()
		{
			return new CreateTableSyntax(this);
		}

		private class CreateTableSyntax : ICreateTableSyntax
		{
			private readonly CreateTableNode _node;

			public CreateTableSyntax(CreateTableNode node)
			{
				_node = node;
			}

			public ICreateTableSyntax AddColumn(string name, Action<IColumnConfigurator> configuration)
			{
				var columnNode = new ColumnNode(name);
				configuration(columnNode.Configurator);
				_node._columnNodes.Add(columnNode);

				return this;
			}

			public ICreateTableSyntax InSchema(string name)
			{
				_node._schema = name;
				return this;
			}

			public IColumnConfigurator AddColumn(string name)
			{
				var columnNode = new ColumnNode(name);
				_node._columnNodes.Add(columnNode);
				return columnNode.Configurator;
			}
		}

		public string GetSql()
		{
			return string.Format("create table {2}.{0} ({1})", _name, _columnNodes.Select(node => node.GetSql()).JoinStrings(", "),
				_schema);
		}
	}
}