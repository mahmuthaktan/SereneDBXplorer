import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { DatabasePropertiesColumns, DatabasePropertiesRow, DatabasePropertiesService } from '../../ServerTypes/Default';
import { DatabasePropertiesDialog } from './DatabasePropertiesDialog';

@Decorators.registerClass('SereneDBXplorer.Default.DatabasePropertiesGrid')
export class DatabasePropertiesGrid extends EntityGrid<DatabasePropertiesRow, any> {
    protected getColumnsKey() { return DatabasePropertiesColumns.columnsKey; }
    protected getDialogType() { return DatabasePropertiesDialog; }
    protected getIdProperty() { return DatabasePropertiesRow.idProperty; }
    protected getInsertPermission() { return DatabasePropertiesRow.insertPermission; }
    protected getLocalTextPrefix() { return DatabasePropertiesRow.localTextPrefix; }
    protected getService() { return DatabasePropertiesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}