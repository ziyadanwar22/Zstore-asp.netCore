
namespace Admin.souqcom {

    @Serenity.Decorators.registerClass()
    export class CartDialog extends Serenity.EntityDialog<CartRow, any> {
        protected getFormKey() { return CartForm.formKey; }
        protected getIdProperty() { return CartRow.idProperty; }
        protected getLocalTextPrefix() { return CartRow.localTextPrefix; }
        protected getNameProperty() { return CartRow.nameProperty; }
        protected getService() { return CartService.baseUrl; }
        protected getDeletePermission() { return CartRow.deletePermission; }
        protected getInsertPermission() { return CartRow.insertPermission; }
        protected getUpdatePermission() { return CartRow.updatePermission; }

        protected form = new CartForm(this.idPrefix);

    }
}