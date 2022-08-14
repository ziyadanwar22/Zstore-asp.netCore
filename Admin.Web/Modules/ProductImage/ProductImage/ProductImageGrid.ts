
namespace Admin.ProductImage {

    @Serenity.Decorators.registerClass()
    export class ProductImageGrid extends Serenity.EntityGrid<ProductImageRow, any> {
        protected getColumnsKey() { return ProductImageColumns.columnsKey; }
        protected getDialogType() { return ProductImageDialog; }
        protected getIdProperty() { return ProductImageRow.idProperty; }
        protected getInsertPermission() { return ProductImageRow.insertPermission; }
        protected getLocalTextPrefix() { return ProductImageRow.localTextPrefix; }
        protected getService() { return ProductImageService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}