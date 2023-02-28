import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { DatabasePropertiesForm, DatabasePropertiesRow, DatabasePropertiesService } from '../../ServerTypes/Default';

@Decorators.registerClass('SereneDBXplorer.Default.DatabasePropertiesDialog')
export class DatabasePropertiesDialog extends EntityDialog<DatabasePropertiesRow, any> {
    protected getFormKey() { return DatabasePropertiesForm.formKey; }
    protected getIdProperty() { return DatabasePropertiesRow.idProperty; }
    protected getLocalTextPrefix() { return DatabasePropertiesRow.localTextPrefix; }
    protected getNameProperty() { return DatabasePropertiesRow.nameProperty; }
    protected getService() { return DatabasePropertiesService.baseUrl; }
    protected getDeletePermission() { return DatabasePropertiesRow.deletePermission; }
    protected getInsertPermission() { return DatabasePropertiesRow.insertPermission; }
    protected getUpdatePermission() { return DatabasePropertiesRow.updatePermission; }

    protected form = new DatabasePropertiesForm(this.idPrefix);
}