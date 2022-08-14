
namespace Admin.ProductImage {

    @Serenity.Decorators.registerClass()
    export class ProductImageDialog extends Serenity.EntityDialog<ProductImageRow, any> {
        protected getFormKey() { return ProductImageForm.formKey; }
        protected getIdProperty() { return ProductImageRow.idProperty; }
        protected getLocalTextPrefix() { return ProductImageRow.localTextPrefix; }
        protected getNameProperty() { return ProductImageRow.nameProperty; }
        protected getService() { return ProductImageService.baseUrl; }
        protected getDeletePermission() { return ProductImageRow.deletePermission; }
        protected getInsertPermission() { return ProductImageRow.insertPermission; }
        protected getUpdatePermission() { return ProductImageRow.updatePermission; }

        protected form = new ProductImageForm(this.idPrefix);

    }
}