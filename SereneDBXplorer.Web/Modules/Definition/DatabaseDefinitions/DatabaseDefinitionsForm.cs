using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace SereneDBXplorer.Definition.Forms
{
    [FormScript("Definition.DatabaseDefinitions")]
    [BasedOnRow(typeof(DatabaseDefinitionsRow), CheckNames = true)]
    public class DatabaseDefinitionsForm
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