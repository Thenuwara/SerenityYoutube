namespace SerenityApp.Market {
    export interface StoreRow {
        Id?: number;
        Name?: string;
        Address?: string;
    }

    export namespace StoreRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Market.Store';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            Address = "Address"
        }
    }
}
