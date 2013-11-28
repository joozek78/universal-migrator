namespace MigrationsDoneRight.SqlImplementation
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using MigrationsDoneRight.Commons;
	using MigrationsDoneRight.Syntax;

	public class SqlMigrationBuilder : IMigrationBuilder
	{
		private readonly List<ISqlNode> _sqlNodes = new List<ISqlNode>();

		public ICreateTableSyntax CreateTable(string name)
		{
			var createTableNode = new CreateTableNode(name);
			_sqlNodes.Add(createTableNode);
			return createTableNode.GetSyntax();
		}

		public string GetSql()
		{
			return _sqlNodes.Select(node => node.GetSql()).JoinStrings(";"+Environment.NewLine);
		}
	}
}