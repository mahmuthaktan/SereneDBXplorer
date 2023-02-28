using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace SereneDBXplorer.Default.Columns
{
    [ColumnsScript("Default.DatabaseProperties")]
    [BasedOnRow(typeof(DatabasePropertiesRow), CheckNames = true)]
    public class DatabasePropertiesColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public long DatabasePropertyId { get; set; }
        [EditLink]
        public string DatabaseName { get; set; }
        public string HostName { get; set; }
        public DateTime CreationDate { get; set; }
        public string DbType { get; set; }
        public bool IsWindowsAuth { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public bool IsActive { get; set; }
    }
}