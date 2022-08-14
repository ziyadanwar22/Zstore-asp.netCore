
namespace Admin.Review {

    @Serenity.Decorators.registerClass()
    export class ReviewGrid extends Serenity.EntityGrid<ReviewRow, any> {
        protected getColumnsKey() { return ReviewColumns.columnsKey; }
        protected getDialogType() { return ReviewDialog; }
        protected getIdProperty() { return ReviewRow.idProperty; }
        protected getInsertPermission() { return ReviewRow.insertPermission; }
        protected getLocalTextPrefix() { return ReviewRow.localTextPrefix; }
        protected getService() { return ReviewService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}