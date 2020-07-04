
namespace SerenityApp.Market {

    @Serenity.Decorators.registerClass()
    export class VisitDialog extends Serenity.EntityDialog<VisitRow, any> {
        protected getFormKey() { return VisitForm.formKey; }
        protected getIdProperty() { return VisitRow.idProperty; }
        protected getLocalTextPrefix() { return VisitRow.localTextPrefix; }
        protected getNameProperty() { return VisitRow.nameProperty; }
        protected getService() { return VisitService.baseUrl; }
        protected getDeletePermission() { return VisitRow.deletePermission; }
        protected getInsertPermission() { return VisitRow.insertPermission; }
        protected getUpdatePermission() { return VisitRow.updatePermission; }

        protected form = new VisitForm(this.idPrefix);

    }
}