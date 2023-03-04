import { Decorators, EntityGrid, QuickSearchField } from '@serenity-is/corelib';
import { text } from '@serenity-is/corelib/q';
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
    protected getQuickSearchFields(): QuickSearchField[]
    {
        const fld = DatabaseDefinitionsRow.Fields;
        const txt = (s) =>
            text(`Db.${DatabaseDefinitionsRow.localTextPrefix}.${s}`).toLowerCase();

        return [
            { name: "", title: "All" },
            { name: fld.DatabaseName, title: txt(fld.DatabaseName) },
            { name: fld.HostName, title: txt(fld.HostName) },
            { name: fld.DbTypeId, title: txt(fld.DbTypeId) }
        ];
    }
}