namespace Admin.ProductImage {
    export interface ProductImageRow {
        Id?: number;
        Productid?: number;
        Image?: string;
        ProductidName?: string;
        ProductidDecription?: string;
        ProductidPrice?: number;
        ProductidCatid?: number;
        ProductidPhoto?: string;
        ProductidType?: string;
        ProductidSupplierName?: string;
        ProductidEntryDate?: string;
        ProductidReveiwUrl?: string;
        ProductidQuntity?: number;
    }

    export namespace ProductImageRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Image';
        export const localTextPrefix = 'ProductImage.ProductImage';
        export const deletePermission = 'Images';
        export const insertPermission = 'Images';
        export const readPermission = 'Images';
        export const updatePermission = 'Images';

        export declare const enum Fields {
            Id = "Id",
            Productid = "Productid",
            Image = "Image",
            ProductidName = "ProductidName",
            ProductidDecription = "ProductidDecription",
            ProductidPrice = "ProductidPrice",
            ProductidCatid = "ProductidCatid",
            ProductidPhoto = "ProductidPhoto",
            ProductidType = "ProductidType",
            ProductidSupplierName = "ProductidSupplierName",
            ProductidEntryDate = "ProductidEntryDate",
            ProductidReveiwUrl = "ProductidReveiwUrl",
            ProductidQuntity = "ProductidQuntity"
        }
    }
}
