import { SaveRequest, SaveResponse, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse } from "@serenity-is/corelib";
import { DatabaseDefinitionsRow } from "./DatabaseDefinitionsRow";
import { ServiceOptions, serviceRequest } from "@serenity-is/corelib/q";

export namespace DatabaseDefinitionsService {
    export const baseUrl = 'Definition/DatabaseDefinitions';

    export declare function Create(request: SaveRequest<DatabaseDefinitionsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<DatabaseDefinitionsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<DatabaseDefinitionsRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<DatabaseDefinitionsRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Definition/DatabaseDefinitions/Create",
        Update: "Definition/DatabaseDefinitions/Update",
        Delete: "Definition/DatabaseDefinitions/Delete",
        Retrieve: "Definition/DatabaseDefinitions/Retrieve",
        List: "Definition/DatabaseDefinitions/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>DatabaseDefinitionsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
