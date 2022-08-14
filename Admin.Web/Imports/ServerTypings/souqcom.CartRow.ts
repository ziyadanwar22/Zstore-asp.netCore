namespace Admin.souqcom {
    export interface CartRow {
        Id?: number;
        UserId?: string;
        ProductId?: number;
        Qty?: number;
        ProductName?: string;
        ProductDecription?: string;
        ProductPrice?: number;
        ProductCatid?: number;
        ProductPhoto?: string;
        ProductType?: string;
        ProductSupplierName?: string;
        ProductEntryDate?: string;
        ProductReveiwUrl?: string;
        ProductQuntity?: number;
    }

    export namespace CartRow {
        export const idProperty = 'Id';
        export const nameProperty = 'UserId';
        export const localTextPrefix = 'souqcom.Cart';
        export const deletePermission = 'Cart';
        export const insertPermission = 'Cart';
        export const readPermission = 'Cart';
        export const updatePermission = 'Cart';

        export declare const enum Fields {
            Id = "Id",
            UserId = "UserId",
            ProductId = "ProductId",
            Qty = "Qty",
            ProductName = "ProductName",
            ProductDecription = "ProductDecription",
            ProductPrice = "ProductPrice",
            ProductCatid = "ProductCatid",
            ProductPhoto = "ProductPhoto",
            ProductType = "ProductType",
            ProductSupplierName = "ProductSupplierName",
            ProductEntryDate = "ProductEntryDate",
            ProductReveiwUrl = "ProductReveiwUrl",
            ProductQuntity = "ProductQuntity"
        }
    }
}
