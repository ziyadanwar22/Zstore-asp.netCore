
namespace Admin.souqcom {

    @Serenity.Decorators.registerClass()
    export class CartGrid extends Serenity.EntityGrid<CartRow, any> {
        protected getColumnsKey() { return CartColumns.columnsKey; }
        protected getDialogType() { return CartDialog; }
        protected getIdProperty() { return CartRow.idProperty; }
        protected getInsertPermission() { return CartRow.insertPermission; }
        protected getLocalTextPrefix() { return CartRow.localTextPrefix; }
        protected getService() { return CartService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}