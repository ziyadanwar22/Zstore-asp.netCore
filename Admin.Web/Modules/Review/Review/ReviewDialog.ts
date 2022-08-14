
namespace Admin.Review {

    @Serenity.Decorators.registerClass()
    export class ReviewDialog extends Serenity.EntityDialog<ReviewRow, any> {
        protected getFormKey() { return ReviewForm.formKey; }
        protected getIdProperty() { return ReviewRow.idProperty; }
        protected getLocalTextPrefix() { return ReviewRow.localTextPrefix; }
        protected getNameProperty() { return ReviewRow.nameProperty; }
        protected getService() { return ReviewService.baseUrl; }
        protected getDeletePermission() { return ReviewRow.deletePermission; }
        protected getInsertPermission() { return ReviewRow.insertPermission; }
        protected getUpdatePermission() { return ReviewRow.updatePermission; }

        protected form = new ReviewForm(this.idPrefix);

    }
}