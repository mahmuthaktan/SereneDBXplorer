import { StringEditor, DateEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface DatabaseDefinitionsForm {
    DatabaseName: StringEditor;
    HostName: StringEditor;
    CreationDate: DateEditor;
    DbType: StringEditor;
    IsWindowsAuth: BooleanEditor;
    Username: StringEditor;
    PasswordHash: StringEditor;
    PasswordSalt: StringEditor;
    IsActive: BooleanEditor;
}

export class DatabaseDefinitionsForm extends PrefixedContext {
    static formKey = 'Definition.DatabaseDefinitions';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!DatabaseDefinitionsForm.init)  {
            DatabaseDefinitionsForm.init = true;

            var w0 = StringEditor;
            var w1 = DateEditor;
            var w2 = BooleanEditor;

            initFormType(DatabaseDefinitionsForm, [
                'DatabaseName', w0,
                'HostName', w0,
                'CreationDate', w1,
                'DbType', w0,
                'IsWindowsAuth', w2,
                'Username', w0,
                'PasswordHash', w0,
                'PasswordSalt', w0,
                'IsActive', w2
            ]);
        }
    }
}
