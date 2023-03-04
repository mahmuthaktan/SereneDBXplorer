import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { DatabaseDefinitionsColumns, DatabaseDefinitionsRow, DatabaseDefinitionsService } from '../../ServerTypes/Definition';
import { DatabaseDefinitionsDialog } from './DatabaseDefinitionsDialog';

@Decorators.registerClass('SereneDBXplorer.Definition.DatabaseDefinitionsGrid')
export class DatabaseDefinitionsGrid extends EntityGrid<DatabaseDefinitionsRow, any> {
    protected getColumnsKey() { return DatabaseDefinitionsColumns.columnsKey; }
    protected getDialogType() { return DatabaseDefinitionsDialog; }
    protected getIdProperty() { return DatabaseDefinitionsRow.idProperty; }
    protected getInsertPermission() { return DatabaseDefinitionsRow.insertPermission; }
    protected getLocalTextPrefix() { return DatabaseDefinitionsRow.localTextPrefix; }
    protected getService() { return DatabaseDefinitionsService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}