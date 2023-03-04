using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace SereneDBXplorer.Definition
{
    [ConnectionKey("Default"), Module("Definition"), TableName("[dbo].[DatabaseDefinitions]")]
    [DisplayName("Database Definitions"), InstanceName("Database Definitions")]
    [ReadPermission("Administration:Definitions")]
    [ModifyPermission("Administration:Definitions")]
    public sealed class DatabaseDefinitionsRow : Row<DatabaseDefinitionsRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Database Definition Id"), Identity, IdProperty]
        public long? DatabaseDefinitionId
        {
            get => fields.DatabaseDefinitionId[this];
            set => fields.DatabaseDefinitionId[this] = value;
        }

        [DisplayName("Database Name"), Size(50), NotNull, QuickSearch, NameProperty]
        public string DatabaseName
        {
            get => fields.DatabaseName[this];
            set => fields.DatabaseName[this] = value;
        }

        [DisplayName("Host Name"), Size(50), NotNull,QuickSearch]
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

        [DisplayName("Db Type"), Column("DbTypeId"), Size(100), NotNull]

        public DBTypeName? DbTypeId
        {
            get => fields.DbTypeId[this];
            set => fields.DbTypeId[this] = value;
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

        public DatabaseDefinitionsRow()
            : base()
        {
        }

        public DatabaseDefinitionsRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field DatabaseDefinitionId;
            public StringField DatabaseName;
            public StringField HostName;
            public DateTimeField CreationDate;
            public EnumField<DBTypeName> DbTypeId;
            public BooleanField IsWindowsAuth;
            public StringField Username;
            public StringField PasswordHash;
            public StringField PasswordSalt;
            public BooleanField IsActive;
        }
    }
}