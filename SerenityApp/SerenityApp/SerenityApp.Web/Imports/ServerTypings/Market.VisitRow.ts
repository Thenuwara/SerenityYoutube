namespace SerenityApp.Market {
    export interface VisitRow {
        VisitId?: number;
        FirstName?: string;
        LastName?: string;
        VisitedAt?: string;
        Phone?: string;
        StoreId?: number;
        StoreName?: string;
        StoreAddress?: string;
    }

    export namespace VisitRow {
        export const idProperty = 'VisitId';
        export const nameProperty = 'FirstName';
        export const localTextPrefix = 'Market.Visit';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            VisitId = "VisitId",
            FirstName = "FirstName",
            LastName = "LastName",
            VisitedAt = "VisitedAt",
            Phone = "Phone",
            StoreId = "StoreId",
            StoreName = "StoreName",
            StoreAddress = "StoreAddress"
        }
    }
}
