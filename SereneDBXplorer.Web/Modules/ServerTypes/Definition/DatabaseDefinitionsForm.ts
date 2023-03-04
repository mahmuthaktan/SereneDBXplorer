import { StringEditor, DateEditor, EnumEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { DBTypeName } from "./DBTypeName";
import { initFormType } from "@serenity-is/corelib/q";

export interface DatabaseDefinitionsForm {
    DatabaseName: StringEditor;
    HostName: StringEditor;
    CreationDate: DateEditor;
    DbTypeId: EnumEditor;
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
            var w2 = EnumEditor;
            var w3 = BooleanEditor;

            initFormType(DatabaseDefinitionsForm, [
                'DatabaseName', w0,
                'HostName', w0,
                'CreationDate', w1,
                'DbTypeId', w2,
                'IsWindowsAuth', w3,
                'Username', w0,
                'PasswordHash', w0,
                'PasswordSalt', w0,
                'IsActive', w3
            ]);
        }
    }
}

[DBTypeName]; // referenced types
