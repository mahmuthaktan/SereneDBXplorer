using Serenity.ComponentModel;
using System.ComponentModel;


namespace SereneDBXplorer.Definition
{
    [EnumKey("DatabaseDefinitions.DBTypeName")]
    public enum DBTypeName
    {
        [Description("Sql Server")]
        SqlServer = 0,
        [Description("Postgre Sql")]
        PostgreSql = 1
    }
}
