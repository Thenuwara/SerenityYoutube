namespace SerenityApp.Market {
    export interface VisitForm {
        FirstName: Serenity.StringEditor;
        LastName: Serenity.StringEditor;
        VisitedAt: Serenity.DateEditor;
        Phone: Serenity.StringEditor;
        StoreId: Serenity.IntegerEditor;
    }

    export class VisitForm extends Serenity.PrefixedContext {
        static formKey = 'Market.Visit';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!VisitForm.init)  {
                VisitForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;
                var w2 = s.IntegerEditor;

                Q.initFormType(VisitForm, [
                    'FirstName', w0,
                    'LastName', w0,
                    'VisitedAt', w1,
                    'Phone', w0,
                    'StoreId', w2
                ]);
            }
        }
    }
}
