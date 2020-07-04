
namespace SerenityApp.Market {

    @Serenity.Decorators.registerClass()
    export class StoreDialog extends Serenity.EntityDialog<StoreRow, any> {
        protected getFormKey() { return StoreForm.formKey; }
        protected getIdProperty() { return StoreRow.idProperty; }
        protected getLocalTextPrefix() { return StoreRow.localTextPrefix; }
        protected getNameProperty() { return StoreRow.nameProperty; }
        protected getService() { return StoreService.baseUrl; }
        protected getDeletePermission() { return StoreRow.deletePermission; }
        protected getInsertPermission() { return StoreRow.insertPermission; }
        protected getUpdatePermission() { return StoreRow.updatePermission; }

        protected form = new StoreForm(this.idPrefix);

    }
}