using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace SereneDBXplorer.Definition.Columns
{
    [ColumnsScript("Definition.DatabaseDefinitions")]
    [BasedOnRow(typeof(DatabaseDefinitionsRow), CheckNames = true)]
    public class DatabaseDefinitionsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public long DatabaseDefinitionId { get; set; }
        [EditLink]
        public string DatabaseName { get; set; }
        [DisplayName("Hostname /Ip Adress"), Width(180), AlignRight]
        public string HostName { get; set; }
        public int DbTypeId { get; set; }
        //public DateTime CreationDate { get; set; }
        //public bool IsWindowsAuth { get; set; }
        //public string Username { get; set; }
        //public string PasswordHash { get; set; }
        //public string PasswordSalt { get; set; }
        //public bool IsActive { get; set; }
    }
}