
namespace SerenityApp.Market {

    @Serenity.Decorators.registerClass()
    export class StoreGrid extends Serenity.EntityGrid<StoreRow, any> {
        protected getColumnsKey() { return 'Market.Store'; }
        protected getDialogType() { return StoreDialog; }
        protected getIdProperty() { return StoreRow.idProperty; }
        protected getInsertPermission() { return StoreRow.insertPermission; }
        protected getLocalTextPrefix() { return StoreRow.localTextPrefix; }
        protected getService() { return StoreService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}