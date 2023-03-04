import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { DatabaseDefinitionsForm, DatabaseDefinitionsRow, DatabaseDefinitionsService } from '../../ServerTypes/Definition';

@Decorators.registerClass('SereneDBXplorer.Definition.DatabaseDefinitionsDialog')
export class DatabaseDefinitionsDialog extends EntityDialog<DatabaseDefinitionsRow, any> {
    protected getFormKey() { return DatabaseDefinitionsForm.formKey; }
    protected getIdProperty() { return DatabaseDefinitionsRow.idProperty; }
    protected getLocalTextPrefix() { return DatabaseDefinitionsRow.localTextPrefix; }
    protected getNameProperty() { return DatabaseDefinitionsRow.nameProperty; }
    protected getService() { return DatabaseDefinitionsService.baseUrl; }
    protected getDeletePermission() { return DatabaseDefinitionsRow.deletePermission; }
    protected getInsertPermission() { return DatabaseDefinitionsRow.insertPermission; }
    protected getUpdatePermission() { return DatabaseDefinitionsRow.updatePermission; }

    protected form = new DatabaseDefinitionsForm(this.idPrefix);
}