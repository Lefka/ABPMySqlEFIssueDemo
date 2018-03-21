using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Migrations.Sql;
using MySql.Data.Entity;

namespace SFP.EntityFramework
{
    /// <summary>
    /// Custom MigrationSqlGenerator to add semi-colons to the end of 
    /// all migration statements.
    /// </summary>
    public class CustomMySqlMigrationSqlGenerator : MySqlMigrationSqlGenerator
    {
        public override IEnumerable<MigrationStatement> Generate(IEnumerable<MigrationOperation> migrationOperations, string providerManifestToken)
        {
            var operations = new List<MigrationOperation>();
            foreach (var item in migrationOperations)
            {
                var migration = item as AlterTableOperation;
                if (migration == null)
                {
                    operations.Add(item);
                }
            }

            var statements = base.Generate(operations, providerManifestToken);

            foreach (MigrationStatement statement in statements)
            {
                if (!statement.Sql.EndsWith(";"))
                {
                    statement.Sql = statement.Sql.TrimEnd() + ";";
                }
            }
            return statements;
        }
    }
}
