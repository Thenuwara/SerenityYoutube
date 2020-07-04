
namespace SerenityApp.Market {

    @Serenity.Decorators.registerClass()
    export class VisitGrid extends Serenity.EntityGrid<VisitRow, any> {
        protected getColumnsKey() { return 'Market.Visit'; }
        protected getDialogType() { return VisitDialog; }
        protected getIdProperty() { return VisitRow.idProperty; }
        protected getInsertPermission() { return VisitRow.insertPermission; }
        protected getLocalTextPrefix() { return VisitRow.localTextPrefix; }
        protected getService() { return VisitService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}