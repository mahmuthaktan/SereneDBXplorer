import { fieldsProxy } from "@serenity-is/corelib/q";

export interface DatabasePropertiesRow {
    DatabasePropertyId?: number;
    DatabaseName?: string;
    HostName?: string;
    CreationDate?: string;
    DbType?: string;
    IsWindowsAuth?: boolean;
    Username?: string;
    PasswordHash?: string;
    PasswordSalt?: string;
    IsActive?: boolean;
}

export abstract class DatabasePropertiesRow {
    static readonly idProperty = 'DatabasePropertyId';
    static readonly nameProperty = 'DatabaseName';
    static readonly localTextPrefix = 'Default.DatabaseProperties';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<DatabasePropertiesRow>();
}
