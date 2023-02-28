import { SaveRequest, SaveResponse, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse } from "@serenity-is/corelib";
import { DatabasePropertiesRow } from "./DatabasePropertiesRow";
import { ServiceOptions, serviceRequest } from "@serenity-is/corelib/q";

export namespace DatabasePropertiesService {
    export const baseUrl = 'Default/DatabaseProperties';

    export declare function Create(request: SaveRequest<DatabasePropertiesRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<DatabasePropertiesRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<DatabasePropertiesRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<DatabasePropertiesRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Default/DatabaseProperties/Create",
        Update: "Default/DatabaseProperties/Update",
        Delete: "Default/DatabaseProperties/Delete",
        Retrieve: "Default/DatabaseProperties/Retrieve",
        List: "Default/DatabaseProperties/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>DatabasePropertiesService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
