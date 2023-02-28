using FluentMigrator;
using Serenity.Extensions;

namespace SereneDBXplorer.Migrations.DefaultDB
{
    [Migration(20200226093200)]
    public class DefaultDB_20200226_093200_DatabaseProperties : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId64("DatabaseProperties", "DatabasePropertyId", s => s 
                .WithColumn("DatabaseName").AsString(50).NotNullable()
                .WithColumn("HostName").AsString(50).NotNullable()
                .WithColumn("CreationDate").AsDateTime().NotNullable()
                .WithColumn("DBType").AsString(100).NotNullable()
                .WithColumn("IsWindowsAuth").AsBoolean().NotNullable().WithDefaultValue(true)
                .WithColumn("Username").AsString(100).NotNullable()
                .WithColumn("PasswordHash").AsString(100).NotNullable()
                .WithColumn("PasswordSalt").AsString(20).NotNullable()
                .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(1));

            Create.Index("IX_DatabaseProperties_DatabaseName_IsActive")
                .OnTable("DatabaseProperties")
                .OnColumn("DatabaseName").Ascending()
                .OnColumn("IsActive").Ascending();

        }
    }
}