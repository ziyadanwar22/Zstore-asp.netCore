namespace Admin.Product {
    export interface ProductRow {
        Id?: number;
        Name?: string;
        Decription?: string;
        Price?: number;
        Catid?: number;
        Photo?: string;
        Type?: string;
        SupplierName?: string;
        EntryDate?: string;
        ReveiwUrl?: string;
        Quntity?: number;
        CatidName?: string;
        CatidPhoto?: string;
        CatidDescription?: string;
    }

    export namespace ProductRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Product.Product';
        export const deletePermission = 'Product';
        export const insertPermission = 'Product';
        export const readPermission = 'Product';
        export const updatePermission = 'Product';

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            Decription = "Decription",
            Price = "Price",
            Catid = "Catid",
            Photo = "Photo",
            Type = "Type",
            SupplierName = "SupplierName",
            EntryDate = "EntryDate",
            ReveiwUrl = "ReveiwUrl",
            Quntity = "Quntity",
            CatidName = "CatidName",
            CatidPhoto = "CatidPhoto",
            CatidDescription = "CatidDescription"
        }
    }
}
