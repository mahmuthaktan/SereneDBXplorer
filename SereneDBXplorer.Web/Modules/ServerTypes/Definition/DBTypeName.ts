import { Decorators } from "@serenity-is/corelib";

export enum DBTypeName {
    SqlServer = 0,
    PostgreSql = 1
}
Decorators.registerEnumType(DBTypeName, 'SereneDBXplorer.Definition.DBTypeName', 'DatabaseDefinitions.DBTypeName');
