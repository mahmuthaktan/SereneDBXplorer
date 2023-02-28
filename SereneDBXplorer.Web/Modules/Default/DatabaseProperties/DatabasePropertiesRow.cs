using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace SereneDBXplorer.Default
{
    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[DatabaseProperties]")]
    [DisplayName("Database Properties"), InstanceName("Database Properties")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class DatabasePropertiesRow : Row<DatabasePropertiesRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Database Property Id"), Identity, IdProperty]
        public long? DatabasePropertyId
        {
            get => fields.DatabasePropertyId[this];
            set => fields.DatabasePropertyId[this] = value;
        }

        [DisplayName("Database Name"), Size(30), NotNull, QuickSearch, NameProperty]
        public string DatabaseName
        {
            get => fields.DatabaseName[this];
            set => fields.DatabaseName[this] = value;
        }

        [DisplayName("Host Name"), Size(50), NotNull]
        public string HostName
        {
            get => fields.HostName[this];
            set => fields.HostName[this] = value;
        }

        [DisplayName("Creation Date"), NotNull]
        public DateTime? CreationDate
        {
            get => fields.CreationDate[this];
            set => fields.CreationDate[this] = value;
        }

        [DisplayName("Db Type"), Column("DBType"), Size(100), NotNull]
        public string DbType
        {
            get => fields.DbType[this];
            set => fields.DbType[this] = value;
        }

        [DisplayName("Is Windows Auth"), NotNull]
        public bool? IsWindowsAuth
        {
            get => fields.IsWindowsAuth[this];
            set => fields.IsWindowsAuth[this] = value;
        }

        [DisplayName("Username"), Size(100), NotNull]
        public string Username
        {
            get => fields.Username[this];
            set => fields.Username[this] = value;
        }

        [DisplayName("Password Hash"), Size(100), NotNull]
        public string PasswordHash
        {
            get => fields.PasswordHash[this];
            set => fields.PasswordHash[this] = value;
        }

        [DisplayName("Password Salt"), Size(20), NotNull]
        public string PasswordSalt
        {
            get => fields.PasswordSalt[this];
            set => fields.PasswordSalt[this] = value;
        }

        [DisplayName("Is Active"), NotNull]
        public bool? IsActive
        {
            get => fields.IsActive[this];
            set => fields.IsActive[this] = value;
        }

        public DatabasePropertiesRow()
            : base()
        {
        }

        public DatabasePropertiesRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field DatabasePropertyId;
            public StringField DatabaseName;
            public StringField HostName;
            public DateTimeField CreationDate;
            public StringField DbType;
            public BooleanField IsWindowsAuth;
            public StringField Username;
            public StringField PasswordHash;
            public StringField PasswordSalt;
            public BooleanField IsActive;
        }
    }
}