import { DBTypeName } from "./DBTypeName";
import { fieldsProxy } from "@serenity-is/corelib/q";

export interface DatabaseDefinitionsRow {
    DatabaseDefinitionId?: number;
    DatabaseName?: string;
    HostName?: string;
    CreationDate?: string;
    DbTypeId?: DBTypeName;
    IsWindowsAuth?: boolean;
    Username?: string;
    PasswordHash?: string;
    PasswordSalt?: string;
    IsActive?: boolean;
}

export abstract class DatabaseDefinitionsRow {
    static readonly idProperty = 'DatabaseDefinitionId';
    static readonly nameProperty = 'DatabaseName';
    static readonly localTextPrefix = 'Definition.DatabaseDefinitions';
    static readonly deletePermission = 'Administration:Definitions';
    static readonly insertPermission = 'Administration:Definitions';
    static readonly readPermission = 'Administration:Definitions';
    static readonly updatePermission = 'Administration:Definitions';

    static readonly Fields = fieldsProxy<DatabaseDefinitionsRow>();
}
