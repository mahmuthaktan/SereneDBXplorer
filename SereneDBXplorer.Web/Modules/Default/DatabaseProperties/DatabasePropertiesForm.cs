using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace SereneDBXplorer.Default.Forms
{
    [FormScript("Default.DatabaseProperties")]
    [BasedOnRow(typeof(DatabasePropertiesRow), CheckNames = true)]
    public class DatabasePropertiesForm
    {
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