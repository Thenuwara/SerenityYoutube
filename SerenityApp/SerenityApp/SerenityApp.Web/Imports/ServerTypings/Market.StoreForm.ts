namespace SerenityApp.Market {
    export interface StoreForm {
        Name: Serenity.StringEditor;
        Address: Serenity.StringEditor;
    }

    export class StoreForm extends Serenity.PrefixedContext {
        static formKey = 'Market.Store';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!StoreForm.init)  {
                StoreForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(StoreForm, [
                    'Name', w0,
                    'Address', w0
                ]);
            }
        }
    }
}
