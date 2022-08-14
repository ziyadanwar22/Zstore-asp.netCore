
namespace Admin.Product {

    @Serenity.Decorators.registerClass()
    export class ProductGrid extends Serenity.EntityGrid<ProductRow, any> {
        protected getColumnsKey() { return ProductColumns.columnsKey; }
        protected getDialogType() { return ProductDialog; }
        protected getIdProperty() { return ProductRow.idProperty; }
        protected getInsertPermission() { return ProductRow.insertPermission; }
        protected getLocalTextPrefix() { return ProductRow.localTextPrefix; }
        protected getService() { return ProductService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}